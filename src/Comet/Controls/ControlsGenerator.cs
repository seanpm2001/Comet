﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui;
using Comet;
//Property:NewPropertyName=DefaultValue
[assembly: CometGenerate(typeof(ILabel), $"{nameof(ILabel.Text)}:Value", Namespace = "Comet", ClassName = "Text", DefaultValues = new[] { "MaxLines = 1" })]
[assembly: CometGenerate(typeof(IButton), nameof(IButton.Text), nameof(IButton.Clicked), Namespace = "Comet")]
[assembly: CometGenerate(typeof(IEntry), nameof(IEntry.Text), nameof(IEntry.Placeholder), nameof(IEntry.Completed), ClassName = "SecureField", Namespace = "Comet", Skip = new[] { $"{nameof(IEntry.IsPassword)}= true" })]
[assembly: CometGenerate(typeof(IActivityIndicator), Namespace ="Comet", Skip = new[] { $"{nameof(IActivityIndicator.IsRunning)}=true" })]
[assembly: CometGenerate(typeof(ICheckBox),  nameof(ICheckBox.IsChecked), Namespace = "Comet")]
[assembly: CometGenerate(typeof(IDatePicker), nameof(IDatePicker.Date), nameof(IDatePicker.MinimumDate), nameof(IDatePicker.MaximumDate), Namespace = "Comet")]
[assembly: CometGenerate(typeof(IProgress), $"{nameof(IProgress.Progress)}:Value", ClassName = "ProgressBar", Namespace = "Comet")]
//[assembly: CometGenerate(typeof(IRadioButton), nameof(IRadioButton.IsChecked), Namespace = "Comet")]
[assembly: CometGenerate(typeof(ISearchBar), nameof(ISearchBar.Text),$"{nameof(ISearchBar.SearchButtonPressed)}:Search", Namespace = "Comet")]
[assembly: CometGenerate(typeof(IEditor), nameof(IEditor.Text), ClassName="TextEditor", Namespace = "Comet")]
[assembly: CometGenerate(typeof(IEntry), nameof(IEntry.Text), nameof(IEntry.Placeholder), nameof(IEntry.Completed), ClassName="TextField", Namespace = "Comet")]
[assembly: CometGenerate(typeof(ISlider), nameof(ISlider.Value),$"{nameof(ISlider.Minimum)}=0", $"{nameof(ISlider.Maximum)}=1", Namespace = "Comet")]
[assembly: CometGenerate(typeof(ISwitch), $"{nameof(ISwitch.IsOn)}:Value", ClassName="Toggle", Namespace = "Comet")]
[assembly: CometGenerate(typeof(ITimePicker), nameof(ITimePicker.Time), Namespace = "Comet")]
[assembly: CometGenerate(typeof(IStepper), nameof(IStepper.Value),nameof(IStepper.Minimum),nameof(IStepper.Maximum),nameof(IStepper.Interval), Namespace = "Comet")]