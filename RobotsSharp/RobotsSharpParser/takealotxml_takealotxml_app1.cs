﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.sitemaps.org/schemas/sitemap/0.9")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.sitemaps.org/schemas/sitemap/0.9", IsNullable=false)]
public partial class urlset {
    
    private urlsetUrl[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("url")]
    public urlsetUrl[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.sitemaps.org/schemas/sitemap/0.9")]
public partial class urlsetUrl {
    
    private string locField;
    
    private string lastmodField;
    
    private string changefreqField;
    
    private string priorityField;
    
    private link linkField;
    
    /// <remarks/>
    public string loc {
        get {
            return this.locField;
        }
        set {
            this.locField = value;
        }
    }
    
    /// <remarks/>
    public string lastmod {
        get {
            return this.lastmodField;
        }
        set {
            this.lastmodField = value;
        }
    }
    
    /// <remarks/>
    public string changefreq {
        get {
            return this.changefreqField;
        }
        set {
            this.changefreqField = value;
        }
    }
    
    /// <remarks/>
    public string priority {
        get {
            return this.priorityField;
        }
        set {
            this.priorityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/1999/xhtml")]
    public link link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/1999/xhtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/1999/xhtml", IsNullable=false)]
public partial class link {
    
    private string hrefField;
    
    private string relField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href {
        get {
            return this.hrefField;
        }
        set {
            this.hrefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rel {
        get {
            return this.relField;
        }
        set {
            this.relField = value;
        }
    }
}
