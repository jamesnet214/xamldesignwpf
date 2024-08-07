﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class FilledButton : Button
    {
        #region MouseOverBackground

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register(
                "MouseOverBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush MouseOverBackground
        {
            get => (Brush)GetValue(MouseOverBackgroundProperty);
            set => SetValue(MouseOverBackgroundProperty, value);
        }
        #endregion

        #region MouseOverBorderBrush

        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.Register(
                "MouseOverBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush MouseOverBorderBrush
        {
            get => (Brush)GetValue(MouseOverBorderBrushProperty);
            set => SetValue(MouseOverBorderBrushProperty, value);
        }
        #endregion

        #region MouseOverForeground

        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.Register(
                "MouseOverForeground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush MouseOverForeground
        {
            get => (Brush)GetValue(MouseOverForegroundProperty);
            set => SetValue(MouseOverForegroundProperty, value);
        }
        #endregion

        #region PressedBackground

        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register(
                "PressedBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush PressedBackground
        {
            get => (Brush)GetValue(PressedBackgroundProperty);
            set => SetValue(PressedBackgroundProperty, value);
        }
        #endregion

        #region PressedBorderBrush

        public static readonly DependencyProperty PressedBorderBrushProperty =
            DependencyProperty.Register(
                "PressedBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush PressedBorderBrush
        {
            get => (Brush)GetValue(PressedBorderBrushProperty);
            set => SetValue(PressedBorderBrushProperty, value);
        }
        #endregion

        #region PressedForeground

        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register(
                "PressedForeground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush PressedForeground
        {
            get => (Brush)GetValue(PressedForegroundProperty);
            set => SetValue(PressedForegroundProperty, value);
        }
        #endregion

        #region DisabledBackground

        public static readonly DependencyProperty DisabledBackgroundProperty =
            DependencyProperty.Register(
                "DisabledBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush DisabledBackground
        {
            get => (Brush)GetValue(DisabledBackgroundProperty);
            set => SetValue(DisabledBackgroundProperty, value);
        }
        #endregion

        #region DisabledBorderBrush

        public static readonly DependencyProperty DisabledBorderBrushProperty =
            DependencyProperty.Register(
                "DisabledBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush DisabledBorderBrush
        {
            get => (Brush)GetValue(DisabledBorderBrushProperty);
            set => SetValue(DisabledBorderBrushProperty, value);
        }
        #endregion

        #region DisabledForeground

        public static readonly DependencyProperty DisabledForegroundProperty =
            DependencyProperty.Register(
                "DisabledForeground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush DisabledForeground
        {
            get => (Brush)GetValue(DisabledForegroundProperty);
            set => SetValue(DisabledForegroundProperty, value);
        }
        #endregion

        #region CornerRadius

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                "CornerRadius",
                typeof(CornerRadius),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        #endregion

        static FilledButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FilledButton), new FrameworkPropertyMetadata(typeof(FilledButton)));
        }
    }
}
