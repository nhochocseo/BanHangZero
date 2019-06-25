using System.Threading.Tasks;
using Center.Production.Schemas;
using Xunit;

namespace Center.Production.GraphQL.Tests.Roles
{
    // ReSharper disable once InconsistentNaming
    public class RoleQuery_Tests : GraphQLTestBase<MainSchema>
    {
        [Fact]
        public async Task Should_Get_Roles()
        {
            LoginAsHostAdmin();

            const string query = @"
             query MyQuery {
                roles {
                  id
                  displayName
                }
             }";


            const string expectedResult = "{ \"roles\": [ { \"id\": 1, \"displayName\": \"Admin\" } ]}";

            await AssertQuerySuccessAsync(query, expectedResult);
        }
    }
}
