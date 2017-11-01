﻿Feature: Analyze Local Method Calls

Scenario: a local method is called within the entrypoint

	Given 'Cucumis.Specifications' contains feature files
	When an analysis is run
	Then the resulting report contains 'When a local method is called within the entrypoint'
	| Kind      | Local | Expression/Signature                                     |
	| When      |       | a local method is called within the entrypoint           |
	| Public    | true  | Cucumis.Gherkin.OnWater(Cucumis.WaterEventArgs), Cucumis |
	| Protected | true  | Cucumis.Gherkin.Grow(), Cucumis                          |
	| Public    |       | System.Console.WriteLine(string), mscorlib               |

Scenario: an explicit base method is called within the entrypoint

	Given 'Cucumis.Specifications' contains feature files
	When an analysis is run
	Then the resulting report contains 'When an explicit base method is called within the entrypoint'
	| Kind      | Local | Expression/Signature                                          |
	| When      |       | an explicit base method is called within the entrypoint       |
	| Public    | true  | Cucumis.PickyGherkin.OnWater(Cucumis.WaterEventArgs), Cucumis |
	| Protected | true  | Cucumis.Gherkin.Grow(), Cucumis                               |
	| Public    |       | System.Console.WriteLine(string), mscorlib                    |

Scenario: a local method is called within the entrypoint explicitly on this

	Given 'Cucumis.Specifications' contains feature files
	When an analysis is run
	Then the resulting report contains 'When a local method is called within the entrypoint explicitly on this'
	| Kind    | Local | Expression/Signature                                              |
	| When    |       | a local method is called within the entrypoint explicitly on this |
	| Public  | true  | Cucumis.Gherkin.OnPlant(Cucumis.PlantEventArgs), Cucumis          |
	| Private | true  | Cucumis.Gherkin.SetInitialSize(string), Cucumis                   |
	| Public  |       | System.Console.WriteLine(string), mscorlib                        |