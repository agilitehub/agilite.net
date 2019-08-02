namespace Agilite.Tests.DataTemplates {
    public static class NumberingData {
        public const string Data = @"{
                                      newItem: {
                                        data: {
                                          key: '',
                                          name: ''
                                        }
                                      },
                                      modifiedItem: {
                                        data: {
                                          key: '',
                                          name: '',
                                          description: 'Test Description',
                                          groupName: 'Test Group',
                                          prefix: 'PRE',
                                          suffix: 'SUF',
                                          startAt: 10,
                                          incrementBasedOn: '3',
                                          minLength: 5
                                        }
                                      }
                                    }";
    }
}
