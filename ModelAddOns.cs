/*
I found these useful as model additions when using the .NET SDK in my project.
I thought it might be helpful to add them to the .NET SDK.
*/
using System;
using System.Collections.Generic;

namespace BuddySDK.Models {

   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyGame: ModelBase {

      [Newtonsoft.Json.JsonProperty("name")]
      public string Name { get; set; }

      [Newtonsoft.Json.JsonProperty("description")]
      public string Description { get; set; }

      [Newtonsoft.Json.JsonProperty("minPlayers")]
      public int MinPlayers { get; set; }

      [Newtonsoft.Json.JsonProperty("maxPlayers")]
      public int MaxPlayers { get; set; }

      [Newtonsoft.Json.JsonProperty("id")]
      new public string ID { get; set; }

      [Newtonsoft.Json.JsonProperty("created")]
      // [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.IsoDateTimeConverter))]
      new public DateTime Created { get; set; }

      [Newtonsoft.Json.JsonProperty("lastModified")]
      new public DateTime LastModified { get; set; }
   }

   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyPlayer: ModelBase {

      [Newtonsoft.Json.JsonProperty("name")]
      public string Name { get; set; }

      [Newtonsoft.Json.JsonProperty("id")]
      new public string ID { get; set; }

      [Newtonsoft.Json.JsonProperty("created")]
      new public DateTime Created { get; set; }

      [Newtonsoft.Json.JsonProperty("lastModified")]
      new public DateTime LastModified { get; set; }
   }

   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyGameSession: ModelBase {

      [Newtonsoft.Json.JsonProperty("game")]
      public string GameID { get; set; }

      [Newtonsoft.Json.JsonProperty("name")]
      public string Name { get; set; }

      [Newtonsoft.Json.JsonProperty("players")]
      public IEnumerable<string> Players { get; set; }

      [Newtonsoft.Json.JsonProperty("id")]
      new public string ID { get; set; }

      [Newtonsoft.Json.JsonProperty("created")]
      new public DateTime Created { get; set; }

      [Newtonsoft.Json.JsonProperty("lastModified")]
      new public DateTime LastModified { get; set; }
   }

   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyScoreBoard: ModelBase {

      [Newtonsoft.Json.JsonProperty("name")]
      public string Name { get; set; }

      [Newtonsoft.Json.JsonProperty("direction")]
      public string Direction { get; set; }

      [Newtonsoft.Json.JsonProperty("scoreCount")]
      public int ScoreCount { get; set; }

      [Newtonsoft.Json.JsonProperty("oneScorePerPlayer")]
      public bool OneScorePerPlayer { get; set; }

      [Newtonsoft.Json.JsonProperty("id")]
      new public string ID { get; set; }

      [Newtonsoft.Json.JsonProperty("created")]
      new public DateTime Created { get; set; }

      [Newtonsoft.Json.JsonProperty("lastModified")]
      new public DateTime LastModified { get; set; }
   }

   // This does not descend fromm ModeBase
   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyScore {
      [Newtonsoft.Json.JsonProperty("scoreboardID")]
      public string ScoreBoardID { get; set; }

      [Newtonsoft.Json.JsonProperty("boardName")]
      public string BoardName { get; set; }

      [Newtonsoft.Json.JsonProperty("position")]
      public int Pos { get; set; }
   }
   
   // This does not descend fromm ModeBase   
   [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
   public class BuddyMeta {

      [Newtonsoft.Json.JsonProperty("key")]
      public string Key { get; set; }

      [Newtonsoft.Json.JsonProperty("value")]
      public string Value { get; set; }

      [Newtonsoft.Json.JsonProperty("created")]
      public DateTime Created { get; set; }

      [Newtonsoft.Json.JsonProperty("lastModified")]
      public DateTime LastModified { get; set; }
      
   }

}
