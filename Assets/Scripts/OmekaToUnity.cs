// Omeka to Unity declaration thanks to serialization
//
// Needs to be updated as soon as new properties/class will come in
// For that, go to : http://serv-gi-34.utbm.fr/api/items?page=all
// Copy ALL le text from the page and paste it in : https://app.quicktype.io
// Choose, C# as langage, Array mode (and not list mode), put "OmekaToUnity" as Name and Generated Namespace
// Then, just copy all the code from the beginning and up to the end (don't forget to keep your packages)
// Replace what is below with the copied code
// Remove "OmekaToUnity" from "OmekaToUnity.Converter.Settings"
// You're normally done

//Class names are inapropriate

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OmekaToUnity;
//
//    var omekaToUnity = OmekaToUnity.FromJson(jsonString);

namespace OmekaToUnity
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OmekaToUnity
    {
        [JsonProperty("@context")]
        public Uri Context { get; set; }

        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("@type")]
        public TypeElement[] Type { get; set; }

        [JsonProperty("o:id")]
        public long OId { get; set; }

        [JsonProperty("o:is_public")]
        public bool OIsPublic { get; set; }

        [JsonProperty("o:owner")]
        public OOwner OOwner { get; set; }

        [JsonProperty("o:resource_class")]
        public OOwner OResourceClass { get; set; }

        [JsonProperty("o:resource_template")]
        public OOwner OResourceTemplate { get; set; }

        [JsonProperty("o:thumbnail")]
        public object OThumbnail { get; set; }

        [JsonProperty("o:title")]
        public string OTitle { get; set; }

        [JsonProperty("thumbnail_display_urls")]
        public ThumbnailDisplayUrls ThumbnailDisplayUrls { get; set; }

        [JsonProperty("o:created")]
        public OCreated OCreated { get; set; }

        [JsonProperty("o:modified")]
        public OCreated OModified { get; set; }

        [JsonProperty("o:media")]
        public OOwner[] OMedia { get; set; }

        [JsonProperty("o:item_set")]
        public object[] OItemSet { get; set; }

        [JsonProperty("o:site")]
        public OOwner[] OSite { get; set; }

        [JsonProperty("skos:prefLabel", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] SkosPrefLabel { get; set; }

        [JsonProperty("schema:legalName", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] SchemaLegalName { get; set; }

        [JsonProperty("rdaa:P50121", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] RdaaP50121 { get; set; }

        [JsonProperty("rdaa:P50120", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] RdaaP50120 { get; set; }

        [JsonProperty("rdaa:P50104", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] RdaaP50104 { get; set; }

        [JsonProperty("owl:sameAs", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] OwlSameAs { get; set; }

        [JsonProperty("@reverse", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Reverse[]> Reverse { get; set; }

        [JsonProperty("rdfs:comment", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] RdfsComment { get; set; }

        [JsonProperty("time:hasBeginning", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] TimeHasBeginning { get; set; }

        [JsonProperty("time:hasEnd", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] TimeHasEnd { get; set; }

        [JsonProperty("rdfs:label", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] RdfsLabel { get; set; }

        [JsonProperty("crm:P2_has_type", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP2HasType { get; set; }

        [JsonProperty("dcterms:title", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] DctermsTitle { get; set; }

        [JsonProperty("crm:P70_documents", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP70Documents { get; set; }

        [JsonProperty("dcterms:creator", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] DctermsCreator { get; set; }

        [JsonProperty("dcterms:issued", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] DctermsIssued { get; set; }

        [JsonProperty("bibo:numPages", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] BiboNumPages { get; set; }

        [JsonProperty("dcterms:alternative", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] DctermsAlternative { get; set; }

        [JsonProperty("schema:color", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] SchemaColor { get; set; }

        [JsonProperty("crm:P43_has_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] CrmP43HasDimension { get; set; }

        [JsonProperty("crm:P53_has_former_or_current_location", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP53HasFormerOrCurrentLocation[] CrmP53HasFormerOrCurrentLocation { get; set; }

        [JsonProperty("schema:comment", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] SchemaComment { get; set; }

        [JsonProperty("dcterms:description", NullValueHandling = NullValueHandling.Ignore)]
        public BiboNumPage[] DctermsDescription { get; set; }

        [JsonProperty("crm:P31_has_modified", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP31HasModified { get; set; }

        [JsonProperty("crm:P46_is_composed_of", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP46IsComposedOf { get; set; }

        [JsonProperty("crm:P108_has_produced", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP108HasProduced { get; set; }

        [JsonProperty("crm:P33_used_specific_technique", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP33UsedSpecificTechnique { get; set; }

        [JsonProperty("crm:P16_used_specific_object", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP16UsedSpecificObject { get; set; }

        [JsonProperty("crm:P9_consists_of", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP9ConsistsOf { get; set; }

        [JsonProperty("crm:P8_took_place_on_or_within", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP8TookPlaceOnOrWithin { get; set; }

        [JsonProperty("crm:P89_falls_within", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP89FallsWithin { get; set; }

        [JsonProperty("crm:P54_has_current_permanent_location", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP54HasCurrentPermanentLocation { get; set; }

        [JsonProperty("crm:P51_has_former_or_current_owner", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP51HasFormerOrCurrentOwner { get; set; }

        [JsonProperty("crm:P196_defines", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP196Defines { get; set; }

        [JsonProperty("rdaa:P50342", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] RdaaP50342 { get; set; }

        [JsonProperty("crm:P27_moved_from", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP27MovedFrom { get; set; }

        [JsonProperty("crm:P26_moved_to", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP26MovedTo { get; set; }

        [JsonProperty("crm:P25_moved", NullValueHandling = NullValueHandling.Ignore)]
        public CrmP108HasProduced[] CrmP25Moved { get; set; }
    }

    public partial class BiboNumPage
    {
        [JsonProperty("type")]
        public BiboNumPageType Type { get; set; }

        [JsonProperty("property_id")]
        public long PropertyId { get; set; }

        [JsonProperty("property_label")]
        public BiboNumPagePropertyLabel PropertyLabel { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("@value")]
        public string Value { get; set; }
    }

    public partial class CrmP108HasProduced
    {
        [JsonProperty("type")]
        public CrmP108HasProducedType Type { get; set; }

        [JsonProperty("property_id")]
        public long PropertyId { get; set; }

        [JsonProperty("property_label")]
        public CrmP108HasProducedPropertyLabel PropertyLabel { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("value_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValueResourceId { get; set; }

        [JsonProperty("value_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public ValueResourceName? ValueResourceName { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("display_title", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayTitle { get; set; }

        [JsonProperty("thumbnail_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ThumbnailUrl { get; set; }

        [JsonProperty("thumbnail_title", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailTitle { get; set; }

        [JsonProperty("thumbnail_type", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailType? ThumbnailType { get; set; }

        [JsonProperty("o:label", NullValueHandling = NullValueHandling.Ignore)]
        public string OLabel { get; set; }
    }

    public partial class CrmP53HasFormerOrCurrentLocation
    {
        [JsonProperty("type")]
        public BiboNumPageType Type { get; set; }

        [JsonProperty("property_id")]
        public long PropertyId { get; set; }

        [JsonProperty("property_label")]
        public CrmP53HasFormerOrCurrentLocationPropertyLabel PropertyLabel { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("@id", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Id { get; set; }

        [JsonProperty("o:label", NullValueHandling = NullValueHandling.Ignore)]
        public string OLabel { get; set; }

        [JsonProperty("@value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class OCreated
    {
        [JsonProperty("@value")]
        public DateTimeOffset Value { get; set; }

        [JsonProperty("@type")]
        public Uri Type { get; set; }
    }

    public partial class OOwner
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("o:id")]
        public long OId { get; set; }
    }

    public partial class Reverse
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("o:title")]
        public string OTitle { get; set; }
    }

    public partial class ThumbnailDisplayUrls
    {
        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("square")]
        public string Square { get; set; }
    }

    public enum BiboNumPagePropertyLabel { AlternativeTitle, Color, Comment, DateIssued, Description, HasBeginning, HasDateOfBirth, HasDateOfDeath, HasDimension, HasEnd, Label, LegalName, NumberOfPages, PreferredLabel, Title };

    public enum BiboNumPageType { Literal, Uri };

    public enum CrmP108HasProducedPropertyLabel { ConsistsOf, Creator, Defines, Documents, FallsWithin, HasCurrentPermanentLocation, HasFormerOrCurrentOwner, HasModified, HasProduced, HasProfessionOrOccupation, HasRelatedPlaceOfCollectiveAgent, HasType, IsComposedOf, Moved, MovedFrom, MovedTo, SameAs, TookPlaceOnOrWithin, UsedSpecificObject, UsedSpecificTechnique };

    public enum ThumbnailType { ImageJpeg, ImagePng };

    public enum CrmP108HasProducedType { Resource, Uri };

    public enum ValueResourceName { Items };

    public enum CrmP53HasFormerOrCurrentLocationPropertyLabel { HasFormerOrCurrentLocation };

    public enum TypeElement { BiboManual, CrmE12Production, CrmE18PhysicalThing, CrmE20BiologicalObject, CrmE22HumanMadeObject, CrmE4Period, CrmE53Place, CrmE55Type, CrmE92SpacetimeVolume, CrmE9Move, OItem, RdacC10004, RdacC10011, SchemaPlace };

    public partial class OmekaToUnity
    {
        public static OmekaToUnity[] FromJson(string json) => JsonConvert.DeserializeObject<OmekaToUnity[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OmekaToUnity[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeElementConverter.Singleton,
                BiboNumPagePropertyLabelConverter.Singleton,
                BiboNumPageTypeConverter.Singleton,
                CrmP108HasProducedPropertyLabelConverter.Singleton,
                ThumbnailTypeConverter.Singleton,
                CrmP108HasProducedTypeConverter.Singleton,
                ValueResourceNameConverter.Singleton,
                CrmP53HasFormerOrCurrentLocationPropertyLabelConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bibo:Manual":
                    return TypeElement.BiboManual;
                case "crm:E12_Production":
                    return TypeElement.CrmE12Production;
                case "crm:E18_Physical_Thing":
                    return TypeElement.CrmE18PhysicalThing;
                case "crm:E20_Biological_Object":
                    return TypeElement.CrmE20BiologicalObject;
                case "crm:E22_Human-Made_Object":
                    return TypeElement.CrmE22HumanMadeObject;
                case "crm:E4_Period":
                    return TypeElement.CrmE4Period;
                case "crm:E53_Place":
                    return TypeElement.CrmE53Place;
                case "crm:E55_Type":
                    return TypeElement.CrmE55Type;
                case "crm:E92_Spacetime_Volume":
                    return TypeElement.CrmE92SpacetimeVolume;
                case "crm:E9_Move":
                    return TypeElement.CrmE9Move;
                case "o:Item":
                    return TypeElement.OItem;
                case "rdac:C10004":
                    return TypeElement.RdacC10004;
                case "rdac:C10011":
                    return TypeElement.RdacC10011;
                case "schema:Place":
                    return TypeElement.SchemaPlace;
            }
            throw new Exception("Cannot unmarshal type TypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeElement)untypedValue;
            switch (value)
            {
                case TypeElement.BiboManual:
                    serializer.Serialize(writer, "bibo:Manual");
                    return;
                case TypeElement.CrmE12Production:
                    serializer.Serialize(writer, "crm:E12_Production");
                    return;
                case TypeElement.CrmE18PhysicalThing:
                    serializer.Serialize(writer, "crm:E18_Physical_Thing");
                    return;
                case TypeElement.CrmE20BiologicalObject:
                    serializer.Serialize(writer, "crm:E20_Biological_Object");
                    return;
                case TypeElement.CrmE22HumanMadeObject:
                    serializer.Serialize(writer, "crm:E22_Human-Made_Object");
                    return;
                case TypeElement.CrmE4Period:
                    serializer.Serialize(writer, "crm:E4_Period");
                    return;
                case TypeElement.CrmE53Place:
                    serializer.Serialize(writer, "crm:E53_Place");
                    return;
                case TypeElement.CrmE55Type:
                    serializer.Serialize(writer, "crm:E55_Type");
                    return;
                case TypeElement.CrmE92SpacetimeVolume:
                    serializer.Serialize(writer, "crm:E92_Spacetime_Volume");
                    return;
                case TypeElement.CrmE9Move:
                    serializer.Serialize(writer, "crm:E9_Move");
                    return;
                case TypeElement.OItem:
                    serializer.Serialize(writer, "o:Item");
                    return;
                case TypeElement.RdacC10004:
                    serializer.Serialize(writer, "rdac:C10004");
                    return;
                case TypeElement.RdacC10011:
                    serializer.Serialize(writer, "rdac:C10011");
                    return;
                case TypeElement.SchemaPlace:
                    serializer.Serialize(writer, "schema:Place");
                    return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }

    internal class BiboNumPagePropertyLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BiboNumPagePropertyLabel) || t == typeof(BiboNumPagePropertyLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Alternative Title":
                    return BiboNumPagePropertyLabel.AlternativeTitle;
                case "Date Issued":
                    return BiboNumPagePropertyLabel.DateIssued;
                case "Description":
                    return BiboNumPagePropertyLabel.Description;
                case "Title":
                    return BiboNumPagePropertyLabel.Title;
                case "color":
                    return BiboNumPagePropertyLabel.Color;
                case "comment":
                    return BiboNumPagePropertyLabel.Comment;
                case "has beginning":
                    return BiboNumPagePropertyLabel.HasBeginning;
                case "has date of birth":
                    return BiboNumPagePropertyLabel.HasDateOfBirth;
                case "has date of death":
                    return BiboNumPagePropertyLabel.HasDateOfDeath;
                case "has dimension":
                    return BiboNumPagePropertyLabel.HasDimension;
                case "has end":
                    return BiboNumPagePropertyLabel.HasEnd;
                case "label":
                    return BiboNumPagePropertyLabel.Label;
                case "legalName":
                    return BiboNumPagePropertyLabel.LegalName;
                case "number of pages":
                    return BiboNumPagePropertyLabel.NumberOfPages;
                case "preferred label":
                    return BiboNumPagePropertyLabel.PreferredLabel;
            }
            throw new Exception("Cannot unmarshal type BiboNumPagePropertyLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BiboNumPagePropertyLabel)untypedValue;
            switch (value)
            {
                case BiboNumPagePropertyLabel.AlternativeTitle:
                    serializer.Serialize(writer, "Alternative Title");
                    return;
                case BiboNumPagePropertyLabel.DateIssued:
                    serializer.Serialize(writer, "Date Issued");
                    return;
                case BiboNumPagePropertyLabel.Description:
                    serializer.Serialize(writer, "Description");
                    return;
                case BiboNumPagePropertyLabel.Title:
                    serializer.Serialize(writer, "Title");
                    return;
                case BiboNumPagePropertyLabel.Color:
                    serializer.Serialize(writer, "color");
                    return;
                case BiboNumPagePropertyLabel.Comment:
                    serializer.Serialize(writer, "comment");
                    return;
                case BiboNumPagePropertyLabel.HasBeginning:
                    serializer.Serialize(writer, "has beginning");
                    return;
                case BiboNumPagePropertyLabel.HasDateOfBirth:
                    serializer.Serialize(writer, "has date of birth");
                    return;
                case BiboNumPagePropertyLabel.HasDateOfDeath:
                    serializer.Serialize(writer, "has date of death");
                    return;
                case BiboNumPagePropertyLabel.HasDimension:
                    serializer.Serialize(writer, "has dimension");
                    return;
                case BiboNumPagePropertyLabel.HasEnd:
                    serializer.Serialize(writer, "has end");
                    return;
                case BiboNumPagePropertyLabel.Label:
                    serializer.Serialize(writer, "label");
                    return;
                case BiboNumPagePropertyLabel.LegalName:
                    serializer.Serialize(writer, "legalName");
                    return;
                case BiboNumPagePropertyLabel.NumberOfPages:
                    serializer.Serialize(writer, "number of pages");
                    return;
                case BiboNumPagePropertyLabel.PreferredLabel:
                    serializer.Serialize(writer, "preferred label");
                    return;
            }
            throw new Exception("Cannot marshal type BiboNumPagePropertyLabel");
        }

        public static readonly BiboNumPagePropertyLabelConverter Singleton = new BiboNumPagePropertyLabelConverter();
    }

    internal class BiboNumPageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BiboNumPageType) || t == typeof(BiboNumPageType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "literal":
                    return BiboNumPageType.Literal;
                case "uri":
                    return BiboNumPageType.Uri;
            }
            throw new Exception("Cannot unmarshal type BiboNumPageType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BiboNumPageType)untypedValue;
            switch (value)
            {
                case BiboNumPageType.Literal:
                    serializer.Serialize(writer, "literal");
                    return;
                case BiboNumPageType.Uri:
                    serializer.Serialize(writer, "uri");
                    return;
            }
            throw new Exception("Cannot marshal type BiboNumPageType");
        }

        public static readonly BiboNumPageTypeConverter Singleton = new BiboNumPageTypeConverter();
    }

    internal class CrmP108HasProducedPropertyLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CrmP108HasProducedPropertyLabel) || t == typeof(CrmP108HasProducedPropertyLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Creator":
                    return CrmP108HasProducedPropertyLabel.Creator;
                case "consists of":
                    return CrmP108HasProducedPropertyLabel.ConsistsOf;
                case "defines":
                    return CrmP108HasProducedPropertyLabel.Defines;
                case "documents":
                    return CrmP108HasProducedPropertyLabel.Documents;
                case "falls within":
                    return CrmP108HasProducedPropertyLabel.FallsWithin;
                case "has current permanent location":
                    return CrmP108HasProducedPropertyLabel.HasCurrentPermanentLocation;
                case "has former or current owner":
                    return CrmP108HasProducedPropertyLabel.HasFormerOrCurrentOwner;
                case "has modified":
                    return CrmP108HasProducedPropertyLabel.HasModified;
                case "has produced":
                    return CrmP108HasProducedPropertyLabel.HasProduced;
                case "has profession or occupation":
                    return CrmP108HasProducedPropertyLabel.HasProfessionOrOccupation;
                case "has related place of collective agent":
                    return CrmP108HasProducedPropertyLabel.HasRelatedPlaceOfCollectiveAgent;
                case "has type":
                    return CrmP108HasProducedPropertyLabel.HasType;
                case "is composed of":
                    return CrmP108HasProducedPropertyLabel.IsComposedOf;
                case "moved":
                    return CrmP108HasProducedPropertyLabel.Moved;
                case "moved from":
                    return CrmP108HasProducedPropertyLabel.MovedFrom;
                case "moved to":
                    return CrmP108HasProducedPropertyLabel.MovedTo;
                case "sameAs":
                    return CrmP108HasProducedPropertyLabel.SameAs;
                case "took place on or within":
                    return CrmP108HasProducedPropertyLabel.TookPlaceOnOrWithin;
                case "used specific object":
                    return CrmP108HasProducedPropertyLabel.UsedSpecificObject;
                case "used specific technique":
                    return CrmP108HasProducedPropertyLabel.UsedSpecificTechnique;
            }
            throw new Exception("Cannot unmarshal type CrmP108HasProducedPropertyLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CrmP108HasProducedPropertyLabel)untypedValue;
            switch (value)
            {
                case CrmP108HasProducedPropertyLabel.Creator:
                    serializer.Serialize(writer, "Creator");
                    return;
                case CrmP108HasProducedPropertyLabel.ConsistsOf:
                    serializer.Serialize(writer, "consists of");
                    return;
                case CrmP108HasProducedPropertyLabel.Defines:
                    serializer.Serialize(writer, "defines");
                    return;
                case CrmP108HasProducedPropertyLabel.Documents:
                    serializer.Serialize(writer, "documents");
                    return;
                case CrmP108HasProducedPropertyLabel.FallsWithin:
                    serializer.Serialize(writer, "falls within");
                    return;
                case CrmP108HasProducedPropertyLabel.HasCurrentPermanentLocation:
                    serializer.Serialize(writer, "has current permanent location");
                    return;
                case CrmP108HasProducedPropertyLabel.HasFormerOrCurrentOwner:
                    serializer.Serialize(writer, "has former or current owner");
                    return;
                case CrmP108HasProducedPropertyLabel.HasModified:
                    serializer.Serialize(writer, "has modified");
                    return;
                case CrmP108HasProducedPropertyLabel.HasProduced:
                    serializer.Serialize(writer, "has produced");
                    return;
                case CrmP108HasProducedPropertyLabel.HasProfessionOrOccupation:
                    serializer.Serialize(writer, "has profession or occupation");
                    return;
                case CrmP108HasProducedPropertyLabel.HasRelatedPlaceOfCollectiveAgent:
                    serializer.Serialize(writer, "has related place of collective agent");
                    return;
                case CrmP108HasProducedPropertyLabel.HasType:
                    serializer.Serialize(writer, "has type");
                    return;
                case CrmP108HasProducedPropertyLabel.IsComposedOf:
                    serializer.Serialize(writer, "is composed of");
                    return;
                case CrmP108HasProducedPropertyLabel.Moved:
                    serializer.Serialize(writer, "moved");
                    return;
                case CrmP108HasProducedPropertyLabel.MovedFrom:
                    serializer.Serialize(writer, "moved from");
                    return;
                case CrmP108HasProducedPropertyLabel.MovedTo:
                    serializer.Serialize(writer, "moved to");
                    return;
                case CrmP108HasProducedPropertyLabel.SameAs:
                    serializer.Serialize(writer, "sameAs");
                    return;
                case CrmP108HasProducedPropertyLabel.TookPlaceOnOrWithin:
                    serializer.Serialize(writer, "took place on or within");
                    return;
                case CrmP108HasProducedPropertyLabel.UsedSpecificObject:
                    serializer.Serialize(writer, "used specific object");
                    return;
                case CrmP108HasProducedPropertyLabel.UsedSpecificTechnique:
                    serializer.Serialize(writer, "used specific technique");
                    return;
            }
            throw new Exception("Cannot marshal type CrmP108HasProducedPropertyLabel");
        }

        public static readonly CrmP108HasProducedPropertyLabelConverter Singleton = new CrmP108HasProducedPropertyLabelConverter();
    }

    internal class ThumbnailTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ThumbnailType) || t == typeof(ThumbnailType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "image/jpeg":
                    return ThumbnailType.ImageJpeg;
                case "image/png":
                    return ThumbnailType.ImagePng;
            }
            throw new Exception("Cannot unmarshal type ThumbnailType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ThumbnailType)untypedValue;
            switch (value)
            {
                case ThumbnailType.ImageJpeg:
                    serializer.Serialize(writer, "image/jpeg");
                    return;
                case ThumbnailType.ImagePng:
                    serializer.Serialize(writer, "image/png");
                    return;
            }
            throw new Exception("Cannot marshal type ThumbnailType");
        }

        public static readonly ThumbnailTypeConverter Singleton = new ThumbnailTypeConverter();
    }

    internal class CrmP108HasProducedTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CrmP108HasProducedType) || t == typeof(CrmP108HasProducedType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "resource":
                    return CrmP108HasProducedType.Resource;
                case "uri":
                    return CrmP108HasProducedType.Uri;
            }
            throw new Exception("Cannot unmarshal type CrmP108HasProducedType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CrmP108HasProducedType)untypedValue;
            switch (value)
            {
                case CrmP108HasProducedType.Resource:
                    serializer.Serialize(writer, "resource");
                    return;
                case CrmP108HasProducedType.Uri:
                    serializer.Serialize(writer, "uri");
                    return;
            }
            throw new Exception("Cannot marshal type CrmP108HasProducedType");
        }

        public static readonly CrmP108HasProducedTypeConverter Singleton = new CrmP108HasProducedTypeConverter();
    }

    internal class ValueResourceNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueResourceName) || t == typeof(ValueResourceName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "items")
            {
                return ValueResourceName.Items;
            }
            throw new Exception("Cannot unmarshal type ValueResourceName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValueResourceName)untypedValue;
            if (value == ValueResourceName.Items)
            {
                serializer.Serialize(writer, "items");
                return;
            }
            throw new Exception("Cannot marshal type ValueResourceName");
        }

        public static readonly ValueResourceNameConverter Singleton = new ValueResourceNameConverter();
    }

    internal class CrmP53HasFormerOrCurrentLocationPropertyLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CrmP53HasFormerOrCurrentLocationPropertyLabel) || t == typeof(CrmP53HasFormerOrCurrentLocationPropertyLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "has former or current location")
            {
                return CrmP53HasFormerOrCurrentLocationPropertyLabel.HasFormerOrCurrentLocation;
            }
            throw new Exception("Cannot unmarshal type CrmP53HasFormerOrCurrentLocationPropertyLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CrmP53HasFormerOrCurrentLocationPropertyLabel)untypedValue;
            if (value == CrmP53HasFormerOrCurrentLocationPropertyLabel.HasFormerOrCurrentLocation)
            {
                serializer.Serialize(writer, "has former or current location");
                return;
            }
            throw new Exception("Cannot marshal type CrmP53HasFormerOrCurrentLocationPropertyLabel");
        }

        public static readonly CrmP53HasFormerOrCurrentLocationPropertyLabelConverter Singleton = new CrmP53HasFormerOrCurrentLocationPropertyLabelConverter();
    }
}

