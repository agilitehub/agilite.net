namespace Agilite.Tests.DataTemplates {
    public static class RolesData {
        public const string Data = @"{
                                      newItem: {
                                        data: {
                                          name: '',
                                          responsibleUser: ['roles.user1@acme.com']
                                        }
                                      },
                                      modifiedItem: {
                                        data: {
                                          isActive: true,
                                          isHidden: true,
                                          name: '',
                                          description: 'Test Description',
                                          groupName: 'Test Group',
                                          responsibleUser: ['roles.user2@acme.com'],
                                          surrogateUser: 'roles.surrogate@acme.com',
                                          levels: ['level1']
                                        }
                                      }
                                    }";
    }
}
