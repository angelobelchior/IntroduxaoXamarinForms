using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace MyFormsApp
{
	public class GitHubViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _user;
		public string User {
			get { return _user; }
			set {

				if(value != _user)
				{
					if(this.PropertyChanged != null)
					{
						_user = value;
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}
			}
		}

		private List<string> _list;
		public List<string> List {
			get { return _list; }
			set {
				if(value != _list)
				{
					_list = value;
					this.PropertyChanged(this, new PropertyChangedEventArgs("List"))
				}
			}
		}
	}
}