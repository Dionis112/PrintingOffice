﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
namespace Roaming.Application.Common.Schemes.DP_PDPOL
{
    // 
    // Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Файл
    {

        private ФайлДокумент документField;

        private string идФайлField;

        private string версПрогField;

        private ФайлВерсФорм версФормField;

        /// <remarks/>
        public ФайлДокумент Документ
        {
            get
            {
                return this.документField;
            }
            set
            {
                this.документField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдФайл
        {
            get
            {
                return this.идФайлField;
            }
            set
            {
                this.идФайлField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВерсПрог
        {
            get
            {
                return this.версПрогField;
            }
            set
            {
                this.версПрогField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ФайлВерсФорм ВерсФорм
        {
            get
            {
                return this.версФормField;
            }
            set
            {
                this.версФормField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ФайлДокумент
    {

        private ФайлДокументОперЭДО оперЭДОField;

        private ФайлДокументСведПодтв сведПодтвField;

        private УчастЭДО отпрДокField;

        private УчастЭДО полДокField;

        private ФайлДокументПодписант подписантField;

        private ФайлДокументКНД кНДField;

        /// <remarks/>
        public ФайлДокументОперЭДО ОперЭДО
        {
            get
            {
                return this.оперЭДОField;
            }
            set
            {
                this.оперЭДОField = value;
            }
        }

        /// <remarks/>
        public ФайлДокументСведПодтв СведПодтв
        {
            get
            {
                return this.сведПодтвField;
            }
            set
            {
                this.сведПодтвField = value;
            }
        }

        /// <remarks/>
        public УчастЭДО ОтпрДок
        {
            get
            {
                return this.отпрДокField;
            }
            set
            {
                this.отпрДокField = value;
            }
        }

        /// <remarks/>
        public УчастЭДО ПолДок
        {
            get
            {
                return this.полДокField;
            }
            set
            {
                this.полДокField = value;
            }
        }

        /// <remarks/>
        public ФайлДокументПодписант Подписант
        {
            get
            {
                return this.подписантField;
            }
            set
            {
                this.подписантField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ФайлДокументКНД КНД
        {
            get
            {
                return this.кНДField;
            }
            set
            {
                this.кНДField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ФайлДокументОперЭДО
    {

        private string наимОргField;

        private string иННЮЛField;

        private string идОперЭДОField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимОрг
        {
            get
            {
                return this.наимОргField;
            }
            set
            {
                this.наимОргField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИННЮЛ
        {
            get
            {
                return this.иННЮЛField;
            }
            set
            {
                this.иННЮЛField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдОперЭДО
        {
            get
            {
                return this.идОперЭДОField;
            }
            set
            {
                this.идОперЭДОField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФИОТип
    {

        private string фамилияField;

        private string имяField;

        private string отчествоField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Фамилия
        {
            get
            {
                return this.фамилияField;
            }
            set
            {
                this.фамилияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Имя
        {
            get
            {
                return this.имяField;
            }
            set
            {
                this.имяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Отчество
        {
            get
            {
                return this.отчествоField;
            }
            set
            {
                this.отчествоField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class УчастЭДО
    {

        private object itemField;

        private string идУчастЭДОField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ИП", typeof(УчастЭДОИП))]
        [System.Xml.Serialization.XmlElementAttribute("ЮЛ", typeof(УчастЭДОЮЛ))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдУчастЭДО
        {
            get
            {
                return this.идУчастЭДОField;
            }
            set
            {
                this.идУчастЭДОField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class УчастЭДОИП
    {

        private ФИОТип фИОField;

        private string иННФЛField;

        /// <remarks/>
        public ФИОТип ФИО
        {
            get
            {
                return this.фИОField;
            }
            set
            {
                this.фИОField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИННФЛ
        {
            get
            {
                return this.иННФЛField;
            }
            set
            {
                this.иННФЛField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class УчастЭДОЮЛ
    {

        private string наимОргField;

        private string иННЮЛField;

        private string кППField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимОрг
        {
            get
            {
                return this.наимОргField;
            }
            set
            {
                this.наимОргField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИННЮЛ
        {
            get
            {
                return this.иННЮЛField;
            }
            set
            {
                this.иННЮЛField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КПП
        {
            get
            {
                return this.кППField;
            }
            set
            {
                this.кППField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ФайлДокументСведПодтв
    {

        private ФайлДокументСведПодтвСведОтпрФайл сведОтпрФайлField;

        private string датаОтпрField;

        private string времяОтпрField;

        /// <remarks/>
        public ФайлДокументСведПодтвСведОтпрФайл СведОтпрФайл
        {
            get
            {
                return this.сведОтпрФайлField;
            }
            set
            {
                this.сведОтпрФайлField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ДатаОтпр
        {
            get
            {
                return this.датаОтпрField;
            }
            set
            {
                this.датаОтпрField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВремяОтпр
        {
            get
            {
                return this.времяОтпрField;
            }
            set
            {
                this.времяОтпрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ФайлДокументСведПодтвСведОтпрФайл
    {

        private string[] эЦППолФайлField;

        private string имяПостФайлаField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ЭЦППолФайл")]
        public string[] ЭЦППолФайл
        {
            get
            {
                return this.эЦППолФайлField;
            }
            set
            {
                this.эЦППолФайлField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИмяПостФайла
        {
            get
            {
                return this.имяПостФайлаField;
            }
            set
            {
                this.имяПостФайлаField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ФайлДокументПодписант
    {

        private ФИОТип фИОField;

        private string должностьField;

        /// <remarks/>
        public ФИОТип ФИО
        {
            get
            {
                return this.фИОField;
            }
            set
            {
                this.фИОField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Должность
        {
            get
            {
                return this.должностьField;
            }
            set
            {
                this.должностьField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ФайлДокументКНД
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1115112")]
        Item1115112,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ФайлВерсФорм
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.02")]
        Item102,
    }
}