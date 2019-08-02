namespace Agilite.Tests.DataTemplates {
    public static class TierStructuresData {
        public const string Data = @"{
                                      newItem: {
                                        data: {
                                          key: '',
                                          values: [{
                                            'label': 'key1',
                                            'value': 'value1'
                                          }]
                                        }
                                      },
                                      modifiedItem: {
                                        data: {
                                          key: '',
                                          description: '',
                                          notes: '',
                                          values: [{
                                            'label': 'key1',
                                            'value': 'value1'
                                          },
                                          {
                                            'label': 'key2',
                                            'value': 'value2'
                                          }
                                          ],
                                          tierEntries: [{
                                            key: 'tier2',
                                            description: 'This is Tier 2',
                                            notes: 'Tier 2 Notes',
                                            values: [{
                                              'label': 'key11',
                                              'value': 'value11'
                                            },
                                            {
                                              'label': 'key22',
                                              'value': 'value22'
                                            }
                                            ]
                                          }]
                                        }
                                      }
                                    }";
    }
}
