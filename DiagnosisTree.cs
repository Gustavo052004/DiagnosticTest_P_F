using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba4_PF
{
	public class DiagnosisTree
	{
		public DecisionNode Root { get; private set; }

		public DiagnosisTree()
		{
			Root = new DecisionNode
			{
				Question = "¿Tiene congestión nasal?",
				YesNode = new DecisionNode
				{
					Question = "¿Tiene dolor de cabeza?",
					YesNode = new DecisionNode
					{
						Question = "¿Tiene fiebre?",
						YesNode = new DecisionNode
						{
							PossibleDisease = new Disease
							{
								Name = "Gripe",
								Symptoms = new List<string> { "fiebre", "dolor de cabeza", "fatiga", "congestión nasal", "dolor de garganta" },
								Treatments = new List<string> { "descanso", "líquidos", "medicamentos para reducir la fiebre y aliviar los síntomas" }
							}
						},
						NoNode = new DecisionNode
						{
							Question = "¿Siente fatiga?",
							YesNode = new DecisionNode
							{
								PossibleDisease = new Disease
								{
									Name = "Gripe",
									Symptoms = new List<string> { "fiebre", "dolor de cabeza", "fatiga", "congestión nasal", "dolor de garganta" },
									Treatments = new List<string> { "descanso", "líquidos", "medicamentos para reducir la fiebre y aliviar los síntomas" }
								}
							}
						}
					},
					NoNode = new DecisionNode
					{
						Question = "¿Tiene dolor de garganta?",
						YesNode = new DecisionNode
						{
							Question = "¿Siente un leve malestar general?",
							YesNode = new DecisionNode
							{
								PossibleDisease = new Disease
								{
									Name = "Resfriado común",
									Symptoms = new List<string> { "congestión nasal", "estornudos", "dolor de garganta", "tos", "leve malestar general" },
									Treatments = new List<string> { "descanso", "líquidos", "medicamentos para aliviar la congestión y la tos" }
								}

							}, NoNode = new DecisionNode
							{
								Question = "¿Tiene estornudos?",
								YesNode = new DecisionNode
								{
									PossibleDisease = new Disease
									{
										Name = "Resfriado común",
										Symptoms = new List<string> { "congestión nasal", "estornudos", "dolor de garganta", "tos", "leve malestar general" },
										Treatments = new List<string> { "descanso", "líquidos", "medicamentos para aliviar la congestión y la tos" }
									}
								}

							}
						},
						NoNode = new DecisionNode
						{
							Question = "¿Tiene dolor facial?",
							YesNode = new DecisionNode
							{
								Question = "¿Tiene presión en los senos paranasales?",
								YesNode = new DecisionNode
								{
									PossibleDisease = new Disease
									{
										Name = "Sinusitis",
										Symptoms = new List<string> { "dolor facial", "presión en los senos paranasales", "secreción nasal espesa y verde", "congestión nasal" },
										Treatments = new List<string> { "analgésicos", "descongestionantes", "irrigación nasal", "humidificadores" }
									}
								}
							},
							NoNode = new DecisionNode
							{
								Question = "¿Tiene secreción nasal espesa y color verde?",
								YesNode = new DecisionNode
								{
									PossibleDisease = new Disease
									{
										Name = "Sinusitis",
										Symptoms = new List<string> { "dolor facial", "presión en los senos paranasales", "secreción nasal espesa y verde", "congestión nasal" },
										Treatments = new List<string> { "analgésicos", "descongestionantes", "irrigación nasal", "humidificadores" }
									}
								},
								NoNode = new DecisionNode
								{
									Question = "¿Presenta erupciones cutaneas?",
									YesNode = new DecisionNode
									{
										PossibleDisease = new Disease
										{
											Name = "Alergia",
											Symptoms = new List<string> { "estornudos", "picazón en los ojos", "congestión nasal", "erupciones cutáneas", "sibilancias" },
											Treatments = new List<string> { "antihistamínicos", "descongestionantes", "evitación del alérgeno" }
										}
									},
									NoNode = new DecisionNode
									{
										Question = "¿Presenta picazón en los ojos?",
										YesNode = new DecisionNode
										{
											PossibleDisease = new Disease
											{
												Name = "Alergia",
												Symptoms = new List<string> { "estornudos", "picazón en los ojos", "congestión nasal", "erupciones cutáneas", "sibilancias" },
												Treatments = new List<string> { "antihistamínicos", "descongestionantes", "evitación del alérgeno" }
											}
										},
										NoNode = new DecisionNode
										{
											Question = "¿Presenta sibilacias?",
											YesNode = new DecisionNode
											{
												PossibleDisease = new Disease
												{
													Name = "Alergia",
													Symptoms = new List<string> { "estornudos", "picazón en los ojos", "congestión nasal", "erupciones cutáneas", "sibilancias" },
													Treatments = new List<string> { "antihistamínicos", "descongestionantes", "evitación del alérgeno" }
												}
											}

										}

									}

								}

							}

						}
					}
				},
				NoNode = new DecisionNode
				{
					Question = "¿Presenta tos?",
					YesNode = new DecisionNode
					{
						Question = "¿Presenta esputo?",
						YesNode = new DecisionNode
						{
							Question = "¿Tiene dificultad para respirar?",
							YesNode = new DecisionNode
							{
								PossibleDisease = new Disease
								{
									Name = "Bronquitis",
									Symptoms = new List<string> { "tos persistente", "producción de esputo", "dificultad para respirar", "fatiga", "dolor en el pecho" },
									Treatments = new List<string> { "descanso", "líquidos", "inhaladores broncodilatadores", "medicamentos para aliviar la tos" }
								}
							}
						},
						NoNode = new DecisionNode
						{
							Question = "¿Tiene dolor en el pecho?",
							YesNode = new DecisionNode
							{
								Question = "¿Tiene fatiga?",
								YesNode = new DecisionNode
								{
									PossibleDisease = new Disease
									{
										Name = "Bronquitis",
										Symptoms = new List<string> { "tos persistente", "producción de esputo", "dificultad para respirar", "fatiga", "dolor en el pecho" },
										Treatments = new List<string> { "descanso", "líquidos", "inhaladores broncodilatadores", "medicamentos para aliviar la tos" }
									}
								}
							}

						}
					}
				}
			};
		}


	}
}