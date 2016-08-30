//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BVNetwork.NotFound.Configuration
{
    
    
    /// <summary>
    /// The Bvn404HandlerConfiguration Configuration Section.
    /// </summary>
    public partial class Bvn404HandlerConfiguration : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the Bvn404HandlerConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string Bvn404HandlerConfigurationSectionName = "bvn404Handler";
        
        /// <summary>
        /// The XML path of the Bvn404HandlerConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string Bvn404HandlerConfigurationSectionPath = "bvn404Handler";
        
        /// <summary>
        /// Gets the Bvn404HandlerConfiguration instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration Instance
        {
            get
            {
                return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration)(global::System.Configuration.ConfigurationManager.GetSection(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.Bvn404HandlerConfigurationSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region RedirectsXmlFile Property
        /// <summary>
        /// The XML name of the <see cref="RedirectsXmlFile"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string RedirectsXmlFilePropertyName = "redirectsXmlFile";
        
        /// <summary>
        /// Gets or sets the RedirectsXmlFile.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The RedirectsXmlFile.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.RedirectsXmlFilePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string RedirectsXmlFile
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.RedirectsXmlFilePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.RedirectsXmlFilePropertyName] = value;
            }
        }
        #endregion
        
        #region HandlerMode Property
        /// <summary>
        /// The XML name of the <see cref="HandlerMode"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string HandlerModePropertyName = "handlerMode";
        
        /// <summary>
        /// Gets or sets the HandlerMode.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The HandlerMode.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.HandlerModePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string HandlerMode
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.HandlerModePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.HandlerModePropertyName] = value;
            }
        }
        #endregion
        
        #region FileNotFoundPage Property
        /// <summary>
        /// The XML name of the <see cref="FileNotFoundPage"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string FileNotFoundPagePropertyName = "fileNotFoundPage";
        
        /// <summary>
        /// Gets or sets the FileNotFoundPage.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The FileNotFoundPage.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.FileNotFoundPagePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string FileNotFoundPage
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.FileNotFoundPagePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.FileNotFoundPagePropertyName] = value;
            }
        }
        #endregion
        
        #region Threshold Property
        /// <summary>
        /// The XML name of the <see cref="Threshold"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string ThresholdPropertyName = "threshold";
        
        /// <summary>
        /// Gets or sets the Threshold.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Threshold.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.ThresholdPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=-1)]
        public virtual int Threshold
        {
            get
            {
                return ((int)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.ThresholdPropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.ThresholdPropertyName] = value;
            }
        }
        #endregion
        
        #region BufferSize Property
        /// <summary>
        /// The XML name of the <see cref="BufferSize"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string BufferSizePropertyName = "bufferSize";
        
        /// <summary>
        /// Gets or sets the BufferSize.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The BufferSize.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.BufferSizePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=-1)]
        public virtual int BufferSize
        {
            get
            {
                return ((int)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.BufferSizePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.BufferSizePropertyName] = value;
            }
        }
        #endregion
        
        #region Logging Property
        /// <summary>
        /// The XML name of the <see cref="Logging"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string LoggingPropertyName = "logging";
        
        /// <summary>
        /// Gets or sets the Logging.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Logging.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.LoggingPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Logging
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.LoggingPropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.LoggingPropertyName] = value;
            }
        }
        #endregion
        
        #region IgnoredResourceExtensions Property
        /// <summary>
        /// The XML name of the <see cref="IgnoredResourceExtensions"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string IgnoredResourceExtensionsPropertyName = "ignoredResourceExtensions";
        
        /// <summary>
        /// Gets or sets the IgnoredResourceExtensions.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The IgnoredResourceExtensions.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.IgnoredResourceExtensionsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string IgnoredResourceExtensions
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.IgnoredResourceExtensionsPropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.IgnoredResourceExtensionsPropertyName] = value;
            }
        }
        #endregion
        
        #region Bvn404HandlerProviders Property
        /// <summary>
        /// The XML name of the <see cref="Bvn404HandlerProviders"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string Bvn404HandlerProvidersPropertyName = "providers";
        
        /// <summary>
        /// Gets or sets the Bvn404HandlerProviders.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Bvn404HandlerProviders.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.Bvn404HandlerProvidersPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=true)]
        public virtual global::BVNetwork.NotFound.Configuration.Bvn404HandlerProviders Bvn404HandlerProviders
        {
            get
            {
                return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProviders)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.Bvn404HandlerProvidersPropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerConfiguration.Bvn404HandlerProvidersPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace BVNetwork.NotFound.Configuration
{
    
    
    /// <summary>
    /// A collection of Bvn404HandlerProvider instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::BVNetwork.NotFound.Configuration.Bvn404HandlerProviders.Bvn404HandlerProviderPropertyName)]
    public partial class Bvn404HandlerProviders : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string Bvn404HandlerProviderPropertyName = "add";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::BVNetwork.NotFound.Configuration.Bvn404HandlerProviders.Bvn404HandlerProviderPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::BVNetwork.NotFound.Configuration.Bvn404HandlerProviders.Bvn404HandlerProviderPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider this[int index]
        {
            get
            {
                return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider this[object name]
        {
            get
            {
                return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="add">The <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider add)
        {
            base.BaseAdd(add);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="add">The <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider add)
        {
            base.BaseRemove(this.GetElementKey(add));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider GetItemAt(int index)
        {
            return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider GetItemByKey(string name)
        {
            return ((global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace BVNetwork.NotFound.Configuration
{
    
    
    /// <summary>
    /// The Bvn404HandlerProvider Configuration Element.
    /// </summary>
    public partial class Bvn404HandlerProvider : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.NamePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Type Property
        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TypePropertyName = "type";
        
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Type.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.TypePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Type
        {
            get
            {
                return ((string)(base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.TypePropertyName]));
            }
            set
            {
                base[global::BVNetwork.NotFound.Configuration.Bvn404HandlerProvider.TypePropertyName] = value;
            }
        }
        #endregion
    }
}
