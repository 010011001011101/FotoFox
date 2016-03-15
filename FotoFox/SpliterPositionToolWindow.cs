using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FotoFox
{
  public partial class SpliterPositionToolWindow : Form
  {
    private readonly SplitContainer _SplitContainer;
    private int _FullSize;
    private bool _CanReactOnValueChange;


    public static void ShowForSplit(SplitContainer container)
    {
      if(container == null) return;

      using (var window = new SpliterPositionToolWindow(container))
        window.ShowDialog(container);
    }

    public SpliterPositionToolWindow()
    {
      InitializeComponent();
    }

    private SpliterPositionToolWindow(SplitContainer container) : this()
    {
      _SplitContainer = container;
      _InitFromSplit();
    }

    private void _InitFromSplit()
    {
      if(_SplitContainer.Orientation == Orientation.Horizontal)
      {
        _FullSize = _SplitContainer.Height - _SplitContainer.SplitterWidth;
        FirstPanelExact.Value = _SplitContainer.Panel1.Height;
        SecondPanelExact.Value = _SplitContainer.Panel2.Height;

        FullSizelabel.Text = string.Format("Полная высота: {0}, Разделитель: {1} (= {2})",
          _FullSize, _SplitContainer.SplitterWidth, _SplitContainer.Height);
        FirstPanelLabel1.Text =
        FirstPanelLabel2.Text = @"Верхняя";
        SecondPanelLabel1.Text =
        SecondPanelLabel2.Text = @"Нижняя";
      }
      else
      {
        _FullSize = _SplitContainer.Width - _SplitContainer.SplitterWidth;
        FirstPanelExact.Value = _SplitContainer.Panel1.Width;
        SecondPanelExact.Value = _SplitContainer.Panel2.Width;

        FullSizelabel.Text = string.Format("Полная длина: {0}, Разделитель: {1} (= {2})",
          _FullSize, _SplitContainer.SplitterWidth, _SplitContainer.Width);
        FirstPanelLabel1.Text =
        FirstPanelLabel2.Text = @"Левая";
        SecondPanelLabel1.Text =
        SecondPanelLabel2.Text = @"Правая";
      }

      FirstPanelExact.Maximum = SecondPanelExact.Maximum = _FullSize;

      _CalculateProportions();

      _CanReactOnValueChange = true;
    }

    private void _CalculateProportions()
    {
      FirstPanelProportion.Value = FirstPanelExact.Value * 100 / _FullSize;
      SecondPanelProportion.Value = SecondPanelExact.Value * 100 / _FullSize;
    }

    private void _CalculateExacts()
    {
      FirstPanelExact.Value = FirstPanelProportion.Value * _FullSize / 100;
      SecondPanelExact.Value = SecondPanelProportion.Value * _FullSize / 100;
    }

    private void FirstPanelProportion_ValueChanged(object sender, EventArgs e)
    {
      _OnValueChange(() =>
      {
        SecondPanelProportion.Value = 100 - FirstPanelProportion.Value;
        _CalculateExacts();
      });
    }

    private void SecondPanelProportion_ValueChanged(object sender, EventArgs e)
    {
      _OnValueChange(() =>
      {
        FirstPanelProportion.Value = 100 - SecondPanelProportion.Value;
        _CalculateExacts();
      });
    }

    private void FirstPanelExact_ValueChanged(object sender, EventArgs e)
    {
      _OnValueChange(() =>
      {
        SecondPanelExact.Value = _FullSize - FirstPanelExact.Value;
        _CalculateProportions();
      });
    }

    private void SecondPanelExact_ValueChanged(object sender, EventArgs e)
    {
      _OnValueChange(() =>
      {
        FirstPanelExact.Value = _FullSize - SecondPanelExact.Value;
        _CalculateProportions();
      });
    }

    private void _OnValueChange(Action action)
    {
      if (!_CanReactOnValueChange) return;

      _CanReactOnValueChange = false;
      action();
      _CanReactOnValueChange = true;

      _SplitContainer.SplitterDistance = (int)FirstPanelExact.Value;
    }
  }
}
