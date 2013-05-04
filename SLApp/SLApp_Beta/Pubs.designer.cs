﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLApp_Beta
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SLDatabase")]
	public partial class PubsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAgency(Agency instance);
    partial void UpdateAgency(Agency instance);
    partial void DeleteAgency(Agency instance);
    partial void InsertApplication_User(Application_User instance);
    partial void UpdateApplication_User(Application_User instance);
    partial void DeleteApplication_User(Application_User instance);
    partial void InsertCommunity_Partnership_Agreement(Community_Partnership_Agreement instance);
    partial void UpdateCommunity_Partnership_Agreement(Community_Partnership_Agreement instance);
    partial void DeleteCommunity_Partnership_Agreement(Community_Partnership_Agreement instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertLearning_Experience(Learning_Experience instance);
    partial void UpdateLearning_Experience(Learning_Experience instance);
    partial void DeleteLearning_Experience(Learning_Experience instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public PubsDataContext() : 
				base(global::SLApp_Beta.Properties.Settings.Default.SLDatabaseConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Agency> Agencies
		{
			get
			{
				return this.GetTable<Agency>();
			}
		}
		
		public System.Data.Linq.Table<Types_of_Service> Types_of_Services
		{
			get
			{
				return this.GetTable<Types_of_Service>();
			}
		}
		
		public System.Data.Linq.Table<Application_User> Application_Users
		{
			get
			{
				return this.GetTable<Application_User>();
			}
		}
		
		public System.Data.Linq.Table<Community_Partnership_Agreement> Community_Partnership_Agreements
		{
			get
			{
				return this.GetTable<Community_Partnership_Agreement>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Learning_Experience> Learning_Experiences
		{
			get
			{
				return this.GetTable<Learning_Experience>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Types_of_Note> Types_of_Notes
		{
			get
			{
				return this.GetTable<Types_of_Note>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Agency")]
	public partial class Agency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _CoordinatorName;
		
		private string _AlternateContact;
		
		private string _StreetAddress;
		
		private string _FaxNumber;
		
		private string _WebsiteLink;
		
		private string _Description;
		
		private System.Nullable<int> _Rating;
		
		private string _Email;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private string _Phone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCoordinatorNameChanging(string value);
    partial void OnCoordinatorNameChanged();
    partial void OnAlternateContactChanging(string value);
    partial void OnAlternateContactChanged();
    partial void OnStreetAddressChanging(string value);
    partial void OnStreetAddressChanged();
    partial void OnFaxNumberChanging(string value);
    partial void OnFaxNumberChanged();
    partial void OnWebsiteLinkChanging(string value);
    partial void OnWebsiteLinkChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnRatingChanging(System.Nullable<int> value);
    partial void OnRatingChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Agency()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoordinatorName", DbType="VarChar(50)")]
		public string CoordinatorName
		{
			get
			{
				return this._CoordinatorName;
			}
			set
			{
				if ((this._CoordinatorName != value))
				{
					this.OnCoordinatorNameChanging(value);
					this.SendPropertyChanging();
					this._CoordinatorName = value;
					this.SendPropertyChanged("CoordinatorName");
					this.OnCoordinatorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlternateContact", DbType="VarChar(50)")]
		public string AlternateContact
		{
			get
			{
				return this._AlternateContact;
			}
			set
			{
				if ((this._AlternateContact != value))
				{
					this.OnAlternateContactChanging(value);
					this.SendPropertyChanging();
					this._AlternateContact = value;
					this.SendPropertyChanged("AlternateContact");
					this.OnAlternateContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress", DbType="VarChar(50)")]
		public string StreetAddress
		{
			get
			{
				return this._StreetAddress;
			}
			set
			{
				if ((this._StreetAddress != value))
				{
					this.OnStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._StreetAddress = value;
					this.SendPropertyChanged("StreetAddress");
					this.OnStreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FaxNumber", DbType="VarChar(50)")]
		public string FaxNumber
		{
			get
			{
				return this._FaxNumber;
			}
			set
			{
				if ((this._FaxNumber != value))
				{
					this.OnFaxNumberChanging(value);
					this.SendPropertyChanging();
					this._FaxNumber = value;
					this.SendPropertyChanged("FaxNumber");
					this.OnFaxNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebsiteLink", DbType="VarChar(50)")]
		public string WebsiteLink
		{
			get
			{
				return this._WebsiteLink;
			}
			set
			{
				if ((this._WebsiteLink != value))
				{
					this.OnWebsiteLinkChanging(value);
					this.SendPropertyChanging();
					this._WebsiteLink = value;
					this.SendPropertyChanged("WebsiteLink");
					this.OnWebsiteLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Int")]
		public System.Nullable<int> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(50)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Types_of_Service")]
	public partial class Types_of_Service
	{
		
		private System.Nullable<bool> _CommunityBasedResearch;
		
		private System.Nullable<bool> _LongTerm;
		
		private System.Nullable<bool> _ShortTerm;
		
		public Types_of_Service()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommunityBasedResearch", DbType="Bit")]
		public System.Nullable<bool> CommunityBasedResearch
		{
			get
			{
				return this._CommunityBasedResearch;
			}
			set
			{
				if ((this._CommunityBasedResearch != value))
				{
					this._CommunityBasedResearch = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LongTerm", DbType="Bit")]
		public System.Nullable<bool> LongTerm
		{
			get
			{
				return this._LongTerm;
			}
			set
			{
				if ((this._LongTerm != value))
				{
					this._LongTerm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortTerm", DbType="Bit")]
		public System.Nullable<bool> ShortTerm
		{
			get
			{
				return this._ShortTerm;
			}
			set
			{
				if ((this._ShortTerm != value))
				{
					this._ShortTerm = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Application_Users")]
	public partial class Application_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<System.DateTime> _Birthdate;
		
		private System.Nullable<bool> _IsAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBirthdateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdateChanged();
    partial void OnIsAdminChanging(System.Nullable<bool> value);
    partial void OnIsAdminChanged();
    #endregion
		
		public Application_User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="Date")]
		public System.Nullable<System.DateTime> Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this.OnIsAdminChanging(value);
					this.SendPropertyChanging();
					this._IsAdmin = value;
					this.SendPropertyChanged("IsAdmin");
					this.OnIsAdminChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Community_Partnership_Agreement")]
	public partial class Community_Partnership_Agreement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<System.DateTime> _DateSigned;
		
		private string _Notes;
		
		private System.Data.Linq.Binary _PDF;
		
		private string _AgencyName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDateSignedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateSignedChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnPDFChanging(System.Data.Linq.Binary value);
    partial void OnPDFChanged();
    partial void OnAgencyNameChanging(string value);
    partial void OnAgencyNameChanged();
    #endregion
		
		public Community_Partnership_Agreement()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateSigned", DbType="Date")]
		public System.Nullable<System.DateTime> DateSigned
		{
			get
			{
				return this._DateSigned;
			}
			set
			{
				if ((this._DateSigned != value))
				{
					this.OnDateSignedChanging(value);
					this.SendPropertyChanging();
					this._DateSigned = value;
					this.SendPropertyChanged("DateSigned");
					this.OnDateSignedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PDF", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary PDF
		{
			get
			{
				return this._PDF;
			}
			set
			{
				if ((this._PDF != value))
				{
					this.OnPDFChanging(value);
					this.SendPropertyChanging();
					this._PDF = value;
					this.SendPropertyChanged("PDF");
					this.OnPDFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string AgencyName
		{
			get
			{
				return this._AgencyName;
			}
			set
			{
				if ((this._AgencyName != value))
				{
					this.OnAgencyNameChanging(value);
					this.SendPropertyChanging();
					this._AgencyName = value;
					this.SendPropertyChanged("AgencyName");
					this.OnAgencyNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CourseNumber;
		
		private string _CourseName;
		
		private System.Nullable<int> _Section;
		
		private string _Professor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseNumberChanging(string value);
    partial void OnCourseNumberChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnSectionChanging(System.Nullable<int> value);
    partial void OnSectionChanged();
    partial void OnProfessorChanging(string value);
    partial void OnProfessorChanged();
    #endregion
		
		public Course()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CourseNumber
		{
			get
			{
				return this._CourseNumber;
			}
			set
			{
				if ((this._CourseNumber != value))
				{
					this.OnCourseNumberChanging(value);
					this.SendPropertyChanging();
					this._CourseNumber = value;
					this.SendPropertyChanged("CourseNumber");
					this.OnCourseNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="VarChar(50)")]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", DbType="Int")]
		public System.Nullable<int> Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this.OnSectionChanging(value);
					this.SendPropertyChanging();
					this._Section = value;
					this.SendPropertyChanged("Section");
					this.OnSectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Professor", DbType="VarChar(50)")]
		public string Professor
		{
			get
			{
				return this._Professor;
			}
			set
			{
				if ((this._Professor != value))
				{
					this.OnProfessorChanging(value);
					this.SendPropertyChanging();
					this._Professor = value;
					this.SendPropertyChanged("Professor");
					this.OnProfessorChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Learning_Experience")]
	public partial class Learning_Experience : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Student_ID;
		
		private string _CourseNumber;
		
		private string _Semester;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<int> _TotalHours;
		
		private string _TypeofLearning;
		
		private bool _ConfirmedHours;
		
		private bool _LiabilityWaiver;
		
		private bool _ProjectAgreement;
		
		private bool _TimeLog;
		
		private int _ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudent_IDChanging(int value);
    partial void OnStudent_IDChanged();
    partial void OnCourseNumberChanging(string value);
    partial void OnCourseNumberChanged();
    partial void OnSemesterChanging(string value);
    partial void OnSemesterChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnTotalHoursChanging(System.Nullable<int> value);
    partial void OnTotalHoursChanged();
    partial void OnTypeofLearningChanging(string value);
    partial void OnTypeofLearningChanged();
    partial void OnConfirmedHoursChanging(bool value);
    partial void OnConfirmedHoursChanged();
    partial void OnLiabilityWaiverChanging(bool value);
    partial void OnLiabilityWaiverChanged();
    partial void OnProjectAgreementChanging(bool value);
    partial void OnProjectAgreementChanged();
    partial void OnTimeLogChanging(bool value);
    partial void OnTimeLogChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Learning_Experience()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Student_ID", DbType="Int NOT NULL")]
		public int Student_ID
		{
			get
			{
				return this._Student_ID;
			}
			set
			{
				if ((this._Student_ID != value))
				{
					this.OnStudent_IDChanging(value);
					this.SendPropertyChanging();
					this._Student_ID = value;
					this.SendPropertyChanged("Student_ID");
					this.OnStudent_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseNumber", DbType="VarChar(50)")]
		public string CourseNumber
		{
			get
			{
				return this._CourseNumber;
			}
			set
			{
				if ((this._CourseNumber != value))
				{
					this.OnCourseNumberChanging(value);
					this.SendPropertyChanging();
					this._CourseNumber = value;
					this.SendPropertyChanged("CourseNumber");
					this.OnCourseNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Semester", DbType="VarChar(50)")]
		public string Semester
		{
			get
			{
				return this._Semester;
			}
			set
			{
				if ((this._Semester != value))
				{
					this.OnSemesterChanging(value);
					this.SendPropertyChanging();
					this._Semester = value;
					this.SendPropertyChanged("Semester");
					this.OnSemesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalHours", DbType="Int")]
		public System.Nullable<int> TotalHours
		{
			get
			{
				return this._TotalHours;
			}
			set
			{
				if ((this._TotalHours != value))
				{
					this.OnTotalHoursChanging(value);
					this.SendPropertyChanging();
					this._TotalHours = value;
					this.SendPropertyChanged("TotalHours");
					this.OnTotalHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeofLearning", DbType="VarChar(50)")]
		public string TypeofLearning
		{
			get
			{
				return this._TypeofLearning;
			}
			set
			{
				if ((this._TypeofLearning != value))
				{
					this.OnTypeofLearningChanging(value);
					this.SendPropertyChanging();
					this._TypeofLearning = value;
					this.SendPropertyChanged("TypeofLearning");
					this.OnTypeofLearningChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmedHours", DbType="Bit NOT NULL")]
		public bool ConfirmedHours
		{
			get
			{
				return this._ConfirmedHours;
			}
			set
			{
				if ((this._ConfirmedHours != value))
				{
					this.OnConfirmedHoursChanging(value);
					this.SendPropertyChanging();
					this._ConfirmedHours = value;
					this.SendPropertyChanged("ConfirmedHours");
					this.OnConfirmedHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LiabilityWaiver", DbType="Bit NOT NULL")]
		public bool LiabilityWaiver
		{
			get
			{
				return this._LiabilityWaiver;
			}
			set
			{
				if ((this._LiabilityWaiver != value))
				{
					this.OnLiabilityWaiverChanging(value);
					this.SendPropertyChanging();
					this._LiabilityWaiver = value;
					this.SendPropertyChanged("LiabilityWaiver");
					this.OnLiabilityWaiverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectAgreement", DbType="Bit NOT NULL")]
		public bool ProjectAgreement
		{
			get
			{
				return this._ProjectAgreement;
			}
			set
			{
				if ((this._ProjectAgreement != value))
				{
					this.OnProjectAgreementChanging(value);
					this.SendPropertyChanging();
					this._ProjectAgreement = value;
					this.SendPropertyChanged("ProjectAgreement");
					this.OnProjectAgreementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeLog", DbType="Bit NOT NULL")]
		public bool TimeLog
		{
			get
			{
				return this._TimeLog;
			}
			set
			{
				if ((this._TimeLog != value))
				{
					this.OnTimeLogChanging(value);
					this.SendPropertyChanging();
					this._TimeLog = value;
					this.SendPropertyChanged("TimeLog");
					this.OnTimeLogChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Student_ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private int _GraduationYear;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudent_IDChanging(int value);
    partial void OnStudent_IDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnGraduationYearChanging(int value);
    partial void OnGraduationYearChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Student_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Student_ID
		{
			get
			{
				return this._Student_ID;
			}
			set
			{
				if ((this._Student_ID != value))
				{
					this.OnStudent_IDChanging(value);
					this.SendPropertyChanging();
					this._Student_ID = value;
					this.SendPropertyChanged("Student_ID");
					this.OnStudent_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GraduationYear", DbType="Int NOT NULL")]
		public int GraduationYear
		{
			get
			{
				return this._GraduationYear;
			}
			set
			{
				if ((this._GraduationYear != value))
				{
					this.OnGraduationYearChanging(value);
					this.SendPropertyChanging();
					this._GraduationYear = value;
					this.SendPropertyChanged("GraduationYear");
					this.OnGraduationYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Types_of_Notes")]
	public partial class Types_of_Note
	{
		
		private System.Nullable<bool> _AgencyVisittoCampus;
		
		private System.Nullable<bool> _AgencyComplaint;
		
		private System.Nullable<bool> _FeedbackFromAgency;
		
		private System.Nullable<bool> _FeedbackFromFaculty;
		
		private System.Nullable<bool> _FeedbackFromStudent;
		
		private System.Nullable<bool> _IncidentReport;
		
		private System.Nullable<bool> _SLFair;
		
		private System.Nullable<bool> _StudentPlacement;
		
		private System.Nullable<bool> _VisittoAgency;
		
		public Types_of_Note()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyVisittoCampus", DbType="Bit")]
		public System.Nullable<bool> AgencyVisittoCampus
		{
			get
			{
				return this._AgencyVisittoCampus;
			}
			set
			{
				if ((this._AgencyVisittoCampus != value))
				{
					this._AgencyVisittoCampus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgencyComplaint", DbType="Bit")]
		public System.Nullable<bool> AgencyComplaint
		{
			get
			{
				return this._AgencyComplaint;
			}
			set
			{
				if ((this._AgencyComplaint != value))
				{
					this._AgencyComplaint = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FeedbackFromAgency", DbType="Bit")]
		public System.Nullable<bool> FeedbackFromAgency
		{
			get
			{
				return this._FeedbackFromAgency;
			}
			set
			{
				if ((this._FeedbackFromAgency != value))
				{
					this._FeedbackFromAgency = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FeedbackFromFaculty", DbType="Bit")]
		public System.Nullable<bool> FeedbackFromFaculty
		{
			get
			{
				return this._FeedbackFromFaculty;
			}
			set
			{
				if ((this._FeedbackFromFaculty != value))
				{
					this._FeedbackFromFaculty = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FeedbackFromStudent", DbType="Bit")]
		public System.Nullable<bool> FeedbackFromStudent
		{
			get
			{
				return this._FeedbackFromStudent;
			}
			set
			{
				if ((this._FeedbackFromStudent != value))
				{
					this._FeedbackFromStudent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IncidentReport", DbType="Bit")]
		public System.Nullable<bool> IncidentReport
		{
			get
			{
				return this._IncidentReport;
			}
			set
			{
				if ((this._IncidentReport != value))
				{
					this._IncidentReport = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLFair", DbType="Bit")]
		public System.Nullable<bool> SLFair
		{
			get
			{
				return this._SLFair;
			}
			set
			{
				if ((this._SLFair != value))
				{
					this._SLFair = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentPlacement", DbType="Bit")]
		public System.Nullable<bool> StudentPlacement
		{
			get
			{
				return this._StudentPlacement;
			}
			set
			{
				if ((this._StudentPlacement != value))
				{
					this._StudentPlacement = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisittoAgency", DbType="Bit")]
		public System.Nullable<bool> VisittoAgency
		{
			get
			{
				return this._VisittoAgency;
			}
			set
			{
				if ((this._VisittoAgency != value))
				{
					this._VisittoAgency = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
