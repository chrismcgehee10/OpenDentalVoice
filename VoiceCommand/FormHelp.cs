﻿/*==================================================================================
This file is a part of Voice Command.
Copyright 2017  Christopher A. McGehee

Voice Command is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Voice Command is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
===================================================================================*/
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace VoiceCommand {
	public partial class FormHelp:Form {
		private List<string> _listCommands;

		public FormHelp(List<string> listCommands) {
			InitializeComponent();
			_listCommands=listCommands;
		}

		private void FormHelp_Load(object sender,EventArgs e) {
			labelVersion.Text+=" "+Assembly.GetExecutingAssembly().GetName().Version.ToString();
			labelCommandList.Text="-"+string.Join("\r\n-",_listCommands);
		}
	}
}
