

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Serializers;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Share.Common
{
    public static class MongoDbPersistence
    {
        public static void Configure()
        {
            CustomMap.Configure();

            // Set Guid to CSharp style (with dash -)
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));
            // Conventions
            var pack = new ConventionPack
                {
                    new IgnoreExtraElementsConvention(true),
                    new IgnoreIfDefaultConvention(true)
                };
            ConventionRegistry.Register("BachDuongIot", pack, t => true);
        }
    }

    public class CustomMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<BaseModel>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.SetIsRootClass(true);
            });
        }
    }
}
