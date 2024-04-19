using Prueba4_PF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosticTest_P_F
{
	public partial class Form1 : Form
	{
		DiagnosisTree tree;
		DecisionNode currentNode;

		public Form1()
		{
			InitializeComponent();
			LimpiarLabels();
		}

		private void BTN_INICIAR_Click(object sender, EventArgs e)
		{
			guna2Transition1.HideSync(P_Inicio);
			guna2Transition1.ShowSync(P_Preguntas);
			StartTest();
		}

		private void BTN_New_Test_Click(object sender, EventArgs e)
		{
			guna2Transition1.ShowSync(P_Inicio);
			guna2Transition1.HideSync(P_diagnostico);
			//StartTest();
			LimpiarLabels();
		}

		private void StartTest()
		{
			tree = new DiagnosisTree();
			currentNode = tree.Root;
			UpdateQuestion();
		}

		private void UpdateQuestion()
		{
			if (currentNode != null && currentNode.PossibleDisease == null)
			{
				L_pregunta.Text = currentNode.Question;
			}
			else if (currentNode != null && currentNode.PossibleDisease != null)
			{
				ShowDiagnosis();
			}
			else
			{
				MessageBox.Show("No se pudo determinar una enfermedad específica basada en los síntomas proporcionados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
				guna2Transition1.ShowSync(P_Inicio);
				guna2Transition1.HideSync(P_Preguntas);
			}
		}

		private void ShowDiagnosis()
		{
			guna2Transition1.HideSync(P_Preguntas);
			guna2Transition1.ShowSync(P_diagnostico);

			L_D_Probable.Text = $"Diagnóstico probable: {currentNode.PossibleDisease.Name}";
			L_Sintomas.Text = string.Join(", ", currentNode.PossibleDisease.Symptoms);
			L_Tratamientos.Text = string.Join(", ", currentNode.PossibleDisease.Treatments);
		}

		private void BTN_NO_Click(object sender, EventArgs e)
		{
			currentNode = currentNode.NoNode;
			UpdateQuestion();
		}

		private void BTN_SI_Click(object sender, EventArgs e)
		{
			currentNode = currentNode.YesNode;
			UpdateQuestion();
		}
		private void LimpiarLabels()
		{
			L_D_Probable.Text = "";
			L_Tratamientos.Clear();
			L_Sintomas.Clear();
			L_pregunta.Text = "";
		}
	}


}
