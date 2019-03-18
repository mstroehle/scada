﻿/*
 * Copyright 2019 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : Administrator
 * Summary  : Form for adding a device
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2019
 * Modified : 2019
 */

using Scada.Admin.App.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scada.Admin.App.Forms.Tools
{
    /// <summary>
    /// Form for adding a device.
    /// <para>Форма для добавления КП.</para>
    /// </summary>
    public partial class FrmDeviceAdd : Form
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public FrmDeviceAdd()
        {
            InitializeComponent();

            txtName.MaxLength = ColumnLength.Name;
            txtCallNum.MaxLength = ColumnLength.Default;
            txtDescr.MaxLength = ColumnLength.Description;
        }

        private void FrmDeviceAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
