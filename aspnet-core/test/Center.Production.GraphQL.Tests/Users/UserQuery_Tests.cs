using System.Threading.Tasks;
using Center.Production.Schemas;
using Xunit;

namespace Center.Production.GraphQL.Tests.Users
{
    // ReSharper disable once InconsistentNaming
    public class UserQuery_Tests : GraphQLTestBase<MainSchema>
    {
        [Fact]
        public async Task Should_Get_Users()
        {
            LoginAsHostAdmin();

            const string query = @"
             query MyQuery {
                users (id:1){
                    totalCount
                    items {
                      name
                      surname

                      roles {
                        id
                        name
                        displayName
                      }

                      organizationUnits {
                        id
                        code
                        displayName
                      }
                    }
                  }
             }";


            const string expectedResult = "{\"users\": {\"totalCount\": 1,\"items\": [{\"name\": \"admin\",\"surname\": \"admin\",\"roles\": [{\"id\": 1,\"name\": \"Admin\",\"displayName\": \"Admin\"}],\"organizationUnits\": []}]}}";

            await AssertQuerySuccessAsync(query, expectedResult);
        }
    }
}
