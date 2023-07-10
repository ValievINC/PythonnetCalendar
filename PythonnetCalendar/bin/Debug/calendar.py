# coding: utf-8 

import clr
clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")

from System.Drawing import Size, Font
from System.Windows.Forms import Application, Form, MonthCalendar

class CountForm(Form):
    def __init__(self):
        super().__init__()
        
        self.Text = 'MyCalendar'

        self.monthCalendar = MonthCalendar()
        self.ClientSize = Size(280, 280)
        self.Font = Font("Arial", 14)
        self.Controls.Add(self.monthCalendar)

form = CountForm()
Application.Run(form)