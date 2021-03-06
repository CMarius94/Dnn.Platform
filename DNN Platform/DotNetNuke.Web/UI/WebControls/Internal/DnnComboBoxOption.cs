﻿// 
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Common;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Client.ClientResourceManagement;
using DotNetNuke.Web.UI.WebControls.Extensions;

#endregion

namespace DotNetNuke.Web.UI.WebControls.Internal
{
    ///<remarks>
    /// This class is added only for internal use, please don't reference it in any other places as it may removed in future.
    /// </remarks>
    [DataContract]
    public class DnnComboBoxOption
    {
        [DataMember(Name = "valueField")]
        public string ValueField { get; } = "value";

        [DataMember(Name = "labelField")]
        public string LabelField { get; } = "text";

        [DataMember(Name = "searchField")]
        public string SearchField { get; } = "text";

        [DataMember(Name = "create")]
        public bool Create { get; set; } = false;

        [DataMember(Name = "preload")]
        public string Preload { get; set; }

        [DataMember(Name = "highlight")]
        public bool Highlight { get; set; }

        [DataMember(Name = "allowEmptyOption")]
        public bool AllowEmptyOption { get; set; }

        [DataMember(Name = "plugins")]
        public IList<string> Plugins { get; set; } = new List<string>();

        [DataMember(Name = "checkbox")]
        public bool Checkbox { get; set; }

        [DataMember(Name = "maxOptions")]
        public int MaxOptions { get; set; }

        [DataMember(Name = "maxItems")]
        public int MaxItems { get; set; }

        [IgnoreDataMember]
        public IEnumerable<ListItem> Items { get; set; }

        [DataMember(Name = "options")]
        public IEnumerable<OptionItem> Options
        {
            get { return Items?.Select(i => new OptionItem {Text = i.Text, Value = i.Value, Selected = i.Selected}); }
        }

        [DataMember(Name = "localization")]
        public IDictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();

        #region Events

        [DataMember(Name = "render")]
        public RenderOption Render { get; set; }

        [DataMember(Name = "load")]
        public string Load { get; set; }

        [DataMember(Name = "onChange")]
        public string OnChangeEvent { get; set; }

        #endregion
    }

    [DataContract]
    public class RenderOption
    {
        [DataMember(Name = "option")]
        public string Option { get; set; }
    }

    [DataContract]
    public class OptionItem
    {
        public OptionItem()
        {
            
        }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "selected")]
        public bool Selected { get; set; }
    }
}
