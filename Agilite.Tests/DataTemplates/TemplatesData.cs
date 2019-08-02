namespace Agilite.Tests.DataTemplates {
    public static class TemplatesData {
        public const string Data = @"{
                                      newItem: {
                                        data: {
                                          isActive: true,
                                          key: '',
                                          description: '',
                                          groupName: '',
                                          data: '<html>Template test</html>',
                                          mode: 'html',
                                          theme: 'monokai'
                                        }
                                      },
                                      modifiedItem: {
                                        data: {
                                          isActive: true,
                                          key: '',
                                          description: 'Test Description',
                                          groupName: 'Test Group Name',
                                          data: '<html>Template test New</html>',
                                          mode: 'html',
                                          theme: 'monokai'
                                        }
                                      }
                                    }";
    }
}
