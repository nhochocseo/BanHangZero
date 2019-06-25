using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using Center.Production.Queries.Container;

namespace Center.Production.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}