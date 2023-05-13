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
namespace Roaming.Application.Common.Schemes.Logical_Message
{
    // 
    // Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd", IsNullable = false)]
    public partial class Сообщение
    {

        private Документ[] документField;

        private ЭП[] эпField;

        private string отправительField;

        private string получательField;

        private string идПодразделенияПолучателяField;

        private System.DateTime датаОтправкиField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Документ")]
        public Документ[] Документ
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
        [System.Xml.Serialization.XmlElementAttribute("ЭП")]
        public ЭП[] ЭП
        {
            get
            {
                return this.эпField;
            }
            set
            {
                this.эпField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Отправитель
        {
            get
            {
                return this.отправительField;
            }
            set
            {
                this.отправительField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Получатель
        {
            get
            {
                return this.получательField;
            }
            set
            {
                this.получательField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдПодразделенияПолучателя
        {
            get
            {
                return this.идПодразделенияПолучателяField;
            }
            set
            {
                this.идПодразделенияПолучателяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ДатаОтправки
        {
            get
            {
                return this.датаОтправкиField;
            }
            set
            {
                this.датаОтправкиField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class Документ
    {

        private string[] кДокументуField;

        private string идВнутреннийField;

        private string идСделкиField;

        private string номерField;

        private System.DateTime датаField;

        private decimal суммаField;

        private bool суммаFieldSpecified;

        private decimal суммаНДСField;

        private bool суммаНДСFieldSpecified;

        private ДокументДополнительныйПараметр[] дополнительныеДанныеField;

        private string идДокументаField;

        private ТипДокумента типДокументаField;

        private bool ожидаетсяПодписьПолучателяField;

        private string имяФайлаField;

        private bool зашифрованField;

        public Документ()
        {
            this.ожидаетсяПодписьПолучателяField = false;
            this.зашифрованField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("КДокументу")]
        public string[] КДокументу
        {
            get
            {
                return this.кДокументуField;
            }
            set
            {
                this.кДокументуField = value;
            }
        }

        /// <remarks/>
        public string ИдВнутренний
        {
            get
            {
                return this.идВнутреннийField;
            }
            set
            {
                this.идВнутреннийField = value;
            }
        }

        /// <remarks/>
        public string ИдСделки
        {
            get
            {
                return this.идСделкиField;
            }
            set
            {
                this.идСделкиField = value;
            }
        }

        /// <remarks/>
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Дата
        {
            get
            {
                return this.датаField;
            }
            set
            {
                this.датаField = value;
            }
        }

        /// <remarks/>
        public decimal Сумма
        {
            get
            {
                return this.суммаField;
            }
            set
            {
                this.суммаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool СуммаSpecified
        {
            get
            {
                return this.суммаFieldSpecified;
            }
            set
            {
                this.суммаFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal СуммаНДС
        {
            get
            {
                return this.суммаНДСField;
            }
            set
            {
                this.суммаНДСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool СуммаНДСSpecified
        {
            get
            {
                return this.суммаНДСFieldSpecified;
            }
            set
            {
                this.суммаНДСFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ДополнительныйПараметр", IsNullable = false)]
        public ДокументДополнительныйПараметр[] ДополнительныеДанные
        {
            get
            {
                return this.дополнительныеДанныеField;
            }
            set
            {
                this.дополнительныеДанныеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдДокумента
        {
            get
            {
                return this.идДокументаField;
            }
            set
            {
                this.идДокументаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ТипДокумента ТипДокумента
        {
            get
            {
                return this.типДокументаField;
            }
            set
            {
                this.типДокументаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ОжидаетсяПодписьПолучателя
        {
            get
            {
                return this.ожидаетсяПодписьПолучателяField;
            }
            set
            {
                this.ожидаетсяПодписьПолучателяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИмяФайла
        {
            get
            {
                return this.имяФайлаField;
            }
            set
            {
                this.имяФайлаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Зашифрован
        {
            get
            {
                return this.зашифрованField;
            }
            set
            {
                this.зашифрованField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class ДокументДополнительныйПараметр
    {

        private string названиеField;

        private string значениеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Название
        {
            get
            {
                return this.названиеField;
            }
            set
            {
                this.названиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Значение
        {
            get
            {
                return this.значениеField;
            }
            set
            {
                this.значениеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class КвитанцияУспех
    {

        private Документ[] документField;

        private ЭП[] эпField;

        private string идЛСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Документ")]
        public Документ[] Документ
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
        [System.Xml.Serialization.XmlElementAttribute("ЭП")]
        public ЭП[] ЭП
        {
            get
            {
                return this.эпField;
            }
            set
            {
                this.эпField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдЛС
        {
            get
            {
                return this.идЛСField;
            }
            set
            {
                this.идЛСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class ЭП
    {

        private string подписантField;

        private string идЭПField;

        private string кДокументуField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Подписант
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
        public string ИдЭП
        {
            get
            {
                return this.идЭПField;
            }
            set
            {
                this.идЭПField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КДокументу
        {
            get
            {
                return this.кДокументуField;
            }
            set
            {
                this.кДокументуField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class КвитанцияОшибкаНеизвестныйИд
    {

        private string[] идField;

        private string описаниеField;

        private string идЛСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ид")]
        public string[] Ид
        {
            get
            {
                return this.идField;
            }
            set
            {
                this.идField = value;
            }
        }

        /// <remarks/>
        public string Описание
        {
            get
            {
                return this.описаниеField;
            }
            set
            {
                this.описаниеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдЛС
        {
            get
            {
                return this.идЛСField;
            }
            set
            {
                this.идЛСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class КвитанцияОшибкаОбработки
    {

        private string описаниеField;

        private string идЛСField;

        /// <remarks/>
        public string Описание
        {
            get
            {
                return this.описаниеField;
            }
            set
            {
                this.описаниеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдЛС
        {
            get
            {
                return this.идЛСField;
            }
            set
            {
                this.идЛСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class ОрганизацияПолучатель
    {

        private string идField;

        private string иННField;

        private string кППField;

        private string наимОргField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ид
        {
            get
            {
                return this.идField;
            }
            set
            {
                this.идField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИНН
        {
            get
            {
                return this.иННField;
            }
            set
            {
                this.иННField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public partial class ОрганизацияОтправитель
    {

        private string идField;

        private string иННField;

        private string кППField;

        private string наимОргField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ид
        {
            get
            {
                return this.идField;
            }
            set
            {
                this.идField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИНН
        {
            get
            {
                return this.иННField;
            }
            set
            {
                this.иННField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public enum ТипДокумента
    {

        /// <remarks/>
        Неформализованный,

        /// <remarks/>
        ОтказПодписи,

        /// <remarks/>
        ТН,

        /// <remarks/>
        ТТН,

        /// <remarks/>
        Акт,

        /// <remarks/>
        АктСверки,

        /// <remarks/>
        ПлатПоруч,

        /// <remarks/>
        Договор,

        /// <remarks/>
        Заказ,

        /// <remarks/>
        СФ,

        /// <remarks/>
        ПодтверждениеОператора,

        /// <remarks/>
        ИзвещениеОПолучении,

        /// <remarks/>
        УведомлениеОбУточнении,

        /// <remarks/>
        ПредложениеОбАннулировании,

        /// <remarks/>
        Торг12ТитулПродавца,

        /// <remarks/>
        Торг12ТитулПокупателя,

        /// <remarks/>
        Торг2ТитулДополнительныхСведенийПоРезультатамПриемки,

        /// <remarks/>
        Торг2ТитулПокупателя,

        /// <remarks/>
        АктТитулЗаказчика,

        /// <remarks/>
        АктТитулИсполнителя,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("КС-11")]
        КС11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("КС-2")]
        КС2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("КС-3")]
        КС3,

        /// <remarks/>
        Ведомость,

        /// <remarks/>
        ДокументОПередачеРезультатовРаботИсполнитель,

        /// <remarks/>
        ДокументОПередачеРезультатовРаботЗаказчик,

        /// <remarks/>
        ДокументОПередачеТоваровПриТорговыхОперацияхПродавец,

        /// <remarks/>
        ДокументОПередачеТоваровПриТорговыхОперацияхПокупатель,

        /// <remarks/>
        СЧФ,

        /// <remarks/>
        СЧФДОППродавец,

        /// <remarks/>
        СЧФДОППокупатель,

        /// <remarks/>
        ДОППродавецНакладная,

        /// <remarks/>
        ДОППродавецАкт,

        /// <remarks/>
        ДОППокупательНакладная,

        /// <remarks/>
        ДОППокупательАкт,

        /// <remarks/>
        ДОППродавец,

        /// <remarks/>
        ДОППокупатель,

        /// <remarks/>
        КорСЧФ,

        /// <remarks/>
        КорСЧФДИСПродавец,

        /// <remarks/>
        КорСЧФДИСПокупатель,

        /// <remarks/>
        КорДИСПродавецНакладная,

        /// <remarks/>
        КорДИСПродавецАкт,

        /// <remarks/>
        КорДИСПокупательНакладная,

        /// <remarks/>
        КорДИСПокупательАкт,

        /// <remarks/>
        КорДИСПродавец,

        /// <remarks/>
        КорДИСПокупатель,

        /// <remarks/>
        Счет,

        /// <remarks/>
        СтруктурированныеДанные,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd", IsNullable = false)]
    public partial class Приглашение
    {

        private ОрганизацияОтправитель оргОтпрField;

        private ОрганизацияПолучатель оргПолField;

        private Документ документField;

        private ЭП эпField;

        private string комментарийField;

        private System.DateTime датаОтправкиField;

        private ТипЗапроса типField;

        /// <remarks/>
        public ОрганизацияОтправитель ОргОтпр
        {
            get
            {
                return this.оргОтпрField;
            }
            set
            {
                this.оргОтпрField = value;
            }
        }

        /// <remarks/>
        public ОрганизацияПолучатель ОргПол
        {
            get
            {
                return this.оргПолField;
            }
            set
            {
                this.оргПолField = value;
            }
        }

        /// <remarks/>
        public Документ Документ
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
        public ЭП ЭП
        {
            get
            {
                return this.эпField;
            }
            set
            {
                this.эпField = value;
            }
        }

        /// <remarks/>
        public string Комментарий
        {
            get
            {
                return this.комментарийField;
            }
            set
            {
                this.комментарийField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ДатаОтправки
        {
            get
            {
                return this.датаОтправкиField;
            }
            set
            {
                this.датаОтправкиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ТипЗапроса Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    public enum ТипЗапроса
    {

        /// <remarks/>
        Запрос,

        /// <remarks/>
        Разрыв,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://www.roseu.org/upload/iblock/0e2/logical-message-v1.xsd", IsNullable = false)]
    public partial class Квитанции
    {

        private КвитанцияОшибкаОбработки[] ошибкаОбработкиField;

        private КвитанцияОшибкаНеизвестныйИд[] неизвестныйИдField;

        private КвитанцияУспех[] успехField;

        private string датаОтправкиField;

        private string получательField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ОшибкаОбработки")]
        public КвитанцияОшибкаОбработки[] ОшибкаОбработки
        {
            get
            {
                return this.ошибкаОбработкиField;
            }
            set
            {
                this.ошибкаОбработкиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("НеизвестныйИд")]
        public КвитанцияОшибкаНеизвестныйИд[] НеизвестныйИд
        {
            get
            {
                return this.неизвестныйИдField;
            }
            set
            {
                this.неизвестныйИдField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Успех")]
        public КвитанцияУспех[] Успех
        {
            get
            {
                return this.успехField;
            }
            set
            {
                this.успехField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ДатаОтправки
        {
            get
            {
                return this.датаОтправкиField;
            }
            set
            {
                this.датаОтправкиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Получатель
        {
            get
            {
                return this.получательField;
            }
            set
            {
                this.получательField = value;
            }
        }
    }
}