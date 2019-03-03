using Roboka.Data.Enum;
using Roboka.Data.Model;
using System.Collections.Generic;

namespace Roboka.Data
{
    public static class Buttons
    {
        public static BotKeypadModel GetKeypad(string buttonId = null)
        {
            var keypad = new BotKeypadModel { Rows = new List<RowModel>() };

            if (buttonId == null || buttonId == ButtonMainMenu.Id)
            {
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button1 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3 } });
            }

            else if (buttonId == Button1.Id || buttonId == Button1_1.Id || buttonId == Button1_2.Id || buttonId == Button1_3.Id || buttonId == Button1_4.Id)
            {
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button1_1 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button1_2 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button1_3 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button1_4 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { ButtonMainMenu } });
            }

            else if (buttonId == Button2.Id || buttonId == Button2_1.Id || buttonId == Button2_2.Id || buttonId == Button2_3.Id || buttonId == Button2_4.Id || buttonId == Button2_5.Id || buttonId == Button2_6.Id)
            {
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_1 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_2 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_3 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_4 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_5 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button2_6 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { ButtonMainMenu } });
            }

            else if (buttonId == Button3.Id || buttonId == Button3_1.Id || buttonId == Button3_2.Id || buttonId == Button3_3.Id || buttonId == Button3_4.Id || buttonId == Button3_5.Id || buttonId == Button3_6.Id || buttonId == Button3_7.Id)
            {
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_1 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_2 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_3 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_4 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_5 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_6 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { Button3_7 } });
                keypad.Rows.Add(new RowModel { Buttons = new List<ButtonModel> { ButtonMainMenu } });
            }

            return keypad;
        }

        #region Buttons

        #region 1

        private static ButtonModel Button1 => new ButtonModel
        {
            Id = "1",
            Type = ButtonTypeEnum.Simple,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Text Inputs"
            },
        };
        private static ButtonModel Button1_1 => new ButtonModel
        {
            Id = "1_1",
            Type = ButtonTypeEnum.NumberPicker,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Number Picker"
            },
            ButtonNumberPicker = new ButtonNumberPickerModel
            {
                DefaultValue = "3",
                MinValue = "1",
                MaxValue = "5"
            }
        };
        private static ButtonModel Button1_2 => new ButtonModel
        {
            Id = "1_2",
            Type = ButtonTypeEnum.StringPicker,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "String Picker"
            },
            ButtonStringPicker = new ButtonStringPickerModel
            {
                DefaultValue = "item 3",
                Items = new List<string> { "item 1", "item 2", "item 3", "item 4", "item 5" }
            }
        };
        private static ButtonModel Button1_3 => new ButtonModel
        {
            Id = "1_3",
            Type = ButtonTypeEnum.Selection,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Selection"
            },
            ButtonSelection = new ButtonSelectionModel
            {
                Type = ButtonSelectionGetTypeEnum.Local,
                SearchType = ButtonSelectionSearchTypeEnum.Local,
                ColumnsCount = "2",
                IsMultiSelection = true,
                Items = new List<ButtonSimpleModel>
                {
                    new ButtonSimpleModel{Type = ButtonSimpleTypeEnum.TextOnly, Text = "1"},
                    new ButtonSimpleModel{Type = ButtonSimpleTypeEnum.TextOnly, Text = "2"},
                    new ButtonSimpleModel{Type = ButtonSimpleTypeEnum.TextOnly, Text = "3"},
                    new ButtonSimpleModel{Type = ButtonSimpleTypeEnum.TextOnly, Text = "4"},
                    new ButtonSimpleModel{Type = ButtonSimpleTypeEnum.TextOnly, Text = "5"},
                }
            }
        };
        private static ButtonModel Button1_4 => new ButtonModel
        {
            Id = "1_4",
            Type = ButtonTypeEnum.Textbox,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Textbox"
            },
            ButtonTextBox = new ButtonTextBoxModel
            {
                TypeKeypad = ButtenTextBoxKeypadEnum.String,
                TypeLine = ButtenTextBoxLineEnum.MultiLine
            }
        };

        #endregion 1

        #region 2

        private static ButtonModel Button2 => new ButtonModel
        {
            Id = "2",
            Type = ButtonTypeEnum.Simple,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "File Inputs"
            },
        };
        private static ButtonModel Button2_1 => new ButtonModel
        {
            Id = "2_1",
            Type = ButtonTypeEnum.CameraImage,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Camera Image"
            }
        };
        private static ButtonModel Button2_2 => new ButtonModel
        {
            Id = "2_2",
            Type = ButtonTypeEnum.CameraVideo,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Camera Video"
            }
        };
        private static ButtonModel Button2_3 => new ButtonModel
        {
            Id = "2_3",
            Type = ButtonTypeEnum.GalleryImage,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Gallery Image"
            }
        };
        private static ButtonModel Button2_4 => new ButtonModel
        {
            Id = "2_4",
            Type = ButtonTypeEnum.GalleryVideo,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Gallery Video"
            }
        };
        private static ButtonModel Button2_5 => new ButtonModel
        {
            Id = "2_5",
            Type = ButtonTypeEnum.File,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "File"
            }
        };
        private static ButtonModel Button2_6 => new ButtonModel
        {
            Id = "2_6",
            Type = ButtonTypeEnum.Audio,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Audio"
            }
        };

        #endregion 2

        #region 3

        private static ButtonModel Button3 => new ButtonModel
        {
            Id = "3",
            Type = ButtonTypeEnum.Simple,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Other Buttons"
            },
        };
        private static ButtonModel Button3_1 => new ButtonModel
        {
            Id = "3_1",
            Type = ButtonTypeEnum.Calendar,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Calendar"
            },
            ButtonCalendar = new ButtonCalendarModel
            {
                Type = ButtonCalendarTypeEnum.DatePersian,
                DefaultValue = "1398-01-01",
                MinYear = "1300",
                MaxYear = "1400"
            }
        };
        private static ButtonModel Button3_2 => new ButtonModel
        {
            Id = "3_2",
            Type = ButtonTypeEnum.Call,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Call"
            },
            ButtonCall = new ButtonCallModel
            {
                PhoneNumber = "02100000000"
            }
        };
        private static ButtonModel Button3_3 => new ButtonModel
        {
            Id = "3_3",
            Type = ButtonTypeEnum.SMS,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "SMS"
            },
            ButtonSms = new ButtonSmsModel
            {
                ToNumber = "0000",
                Message = "Sample SMS text!"
            }
        };
        private static ButtonModel Button3_4 => new ButtonModel
        {
            Id = "3_4",
            Type = ButtonTypeEnum.Barcode,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Barcode"
            }
        };
        private static ButtonModel Button3_5 => new ButtonModel
        {
            Id = "3_5",
            Type = ButtonTypeEnum.Alert,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Alert"
            },
            ButtonAlert = new ButtonAlertModel
            {
                Message = "Alert message!"
            }
        };
        private static ButtonModel Button3_6 => new ButtonModel
        {
            Id = "3_6",
            Type = ButtonTypeEnum.LocationPicker,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Location Picker"
            },
            ButtonLocation = new ButtonLocationModel
            {
                DefaultMapLocation = new LocationModel { Latitude = "35.6962301", Longitude = "51.3975915" },
                DefaultPointerLocation = new LocationModel { Latitude = "35.6998404", Longitude = "51.3380701" }
            }
        };
        private static ButtonModel Button3_7 => new ButtonModel
        {
            Id = "3_7",
            Type = ButtonTypeEnum.AskMyLocation,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "My Location"
            }
        };

        #endregion 3

        private static ButtonModel ButtonMainMenu => new ButtonModel
        {
            Id = "0",
            Type = ButtonTypeEnum.Simple,
            ButtonView = new ButtonSimpleModel
            {
                Type = ButtonSimpleTypeEnum.TextOnly,
                Text = "Return"
            }
        };

        #endregion
    }
}
