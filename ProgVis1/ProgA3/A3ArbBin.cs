using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgA3
{
    public partial class A3ArbBin : Form
    {
        public A3ArbBin()
        {
            InitializeComponent();
        }

        Nodo a; Nodo b; Nodo c; Nodo d; Nodo e; Nodo f;

        private void Form1_Load(object sender, EventArgs ex)
        {
            a = new Nodo() { texto = "A" };
            b = new Nodo() { texto = "B" };
            c = new Nodo() { texto = "C" };
            d = new Nodo() { texto = "D" };
            e = new Nodo() { texto = "E" };
            f = new Nodo() { texto = "F" };

            a.Izq = b;
            a.Der = c;
            b.Der = d;
            c.Izq = e;
            c.Der = f;

            treeView1.Nodes.Clear();

            List<Nodo> LN = new List<Nodo>(); LN.Add(a);

            Mostrar (null, LN);

            treeView1.ExpandAll();
        }
        private void Mostrar(List<TreeNode>pTreeNode, List<Nodo> pNodo)
        {
            if (pNodo != null)
            {
                bool Sale = true;
                foreach (Nodo N in pNodo)
                {
                    if (N != null) { Sale = false; break; }
                }

                if(!Sale)
                {
                    List<Nodo> LNT = new List<Nodo>();

                    List<TreeNode> LTNT = new List<TreeNode>();

                    if (pTreeNode == null)
                    {
                        treeView1.Nodes.Add(pNodo[0].texto);
                        
                        if (pNodo[0].Izq != null) { LNT.Add(pNodo[0].Izq); }
                        else { LNT.Add(null); }

                        if (pNodo[0].Der != null) { LNT.Add(pNodo[0].Der); }
                        else { LNT.Add(null ); }

                        LTNT.Add(treeView1.Nodes[0]);
                    }

                    else
                    {
                        foreach (TreeNode N in pTreeNode)
                        {
                            if (N.Text != "Null")
                            {
                                string texto = "Null";

                                if (pNodo.ElementAt(N.Index * 2) != null)
                                {
                                    texto = pNodo.ElementAt(N.Index * 2).texto;
                                    LNT.Add(pNodo.ElementAt(N.Index * 2).Izq);
                                    LNT.Add(pNodo.ElementAt(N.Index * 2).Der);
                                }

                                else { LNT.Add(null); LNT.Add(null); }


                                N.Nodes.Add(new TreeNode(texto));

                                LTNT.Add(N.LastNode);

                                texto = "Null";

                                if (pNodo.ElementAt(N.Index * 2+1) != null)
                                {
                                    texto = pNodo.ElementAt(N.Index * 2+1).texto;
                                    LNT.Add(pNodo.ElementAt(N.Index * 2+1).Izq);
                                    LNT.Add(pNodo.ElementAt(N.Index * 2+1).Der);
                                }

                                else { LNT.Add(null); LNT.Add(null); }


                                N.Nodes.Add(new TreeNode(texto));

                                LTNT.Add(N.LastNode);
                            }
                        }
                    }
                    Mostrar(LTNT, LNT);
                }
            }
        }
        
        private void Preorder(Nodo pNodo) 
        {
            if (pNodo != null )
            {
                textBox1.Text += pNodo.texto + " ";
                Preorder(pNodo.Izq);
                Preorder(pNodo.Der);
            }
        }

        private void Inorder(Nodo pNodo)
        {
            if (pNodo != null )
            {
                Inorder(pNodo.Izq);
                textBox2.Text += pNodo.texto + " ";
                Inorder(pNodo.Der);
            }
        }

        private void Posorder(Nodo pNodo)
        {
            if (pNodo != null )
            {
                Posorder(pNodo.Izq);
                Posorder(pNodo.Der);
                textBox3.Text += pNodo.texto + " ";
            }
        }

        private void Anchura(List<Nodo> pLnodo)
        {
            if (pLnodo.Count>0)
            {
                List<Nodo> LT = new List<Nodo>();
                foreach (Nodo N in pLnodo)
                {
                    textBox4.Text += N.texto + " ";
                    if (N.Izq != null) LT.Add(N.Izq);
                    if (N.Der != null) LT.Add(N.Der);
                }
                Anchura(LT);
            }
        }

        private void AnchuraConNull(List<Nodo> pLnodo)
        {
            if(pLnodo.FindAll(x => x.texto != "@").Count() > 0)
            {
                List<Nodo> LT = new List<Nodo>();

                foreach (Nodo N in pLnodo)
                {
                    textBox5.Text += N.texto;

                    LT.Add(N.Izq!= null ? N.Izq : new Nodo("@"));

                    LT.Add(N.Der != null ? N.Der : new Nodo("@"));
                }

                AnchuraConNull(LT);
            }
        }

        private void CargaTreeView2(TreeView pTreeView, Nodo pRaiz)
        {
            if(pRaiz != null&& pRaiz.texto != "@")
            {

                pTreeView.Nodes.Add(pRaiz.texto);

                CargaTreeView2Recursivo(new List<TreeNode> { pTreeView.Nodes[0] }, new List<Nodo> { pRaiz.Izq, pRaiz.Der});
                pTreeView.ExpandAll();
            }
        }

        private void CargaTreeView2Recursivo(List<TreeNode> pListaTreeView, List<Nodo> pListaArbol)
        {
            if (pListaArbol.FindAll(x=>x.texto!="@").Count>0) 
            {
                List<TreeNode> _auxListaTreeView = new List<TreeNode>();

                List <Nodo> _auxListaArbol = new List<Nodo>();

                foreach (TreeNode nt in pListaTreeView)
                {
                    for (int x=0; x<2;x++)
                    {
                        nt.Nodes.Add(pListaArbol[0].texto == "@" ? "null": pListaArbol[0].texto);

                        _auxListaArbol.Add(pListaArbol.First().Izq != null ? pListaArbol.First().Izq : new Nodo("@"));
                        _auxListaArbol.Add(pListaArbol.First().Der != null ? pListaArbol.First().Der : new Nodo("@"));

                        pListaArbol.RemoveAt(0);


                        _auxListaTreeView.Add(nt.Nodes[nt.Nodes.Count-1]);
                    }
                }
                CargaTreeView2Recursivo(_auxListaTreeView, _auxListaArbol);
            }
        }

        Nodo StringToTree(string pString)
        {
            int q = 1;
            var raiz = new Nodo(pString.Substring(0,1));

            StringToTreeRecursivo(q, new List<Nodo> { raiz }, pString.Substring(1));
                        
            return raiz;
        }

        void StringToTreeRecursivo(int pPosicion, List<Nodo> pLista, string pString)
        {
            if (pString.Length > 0)
            {
                List<Nodo> auxLista = new List<Nodo>();

                foreach(Nodo n in pLista)
                {

                    n.Izq = new Nodo(pString.Substring(0, 1));

                    n.Der = new Nodo(pString.Substring(1,1));

                    auxLista.AddRange(new Nodo[] {n.Izq,n.Der});

                    pString = pString.Substring(2);
                }
                StringToTreeRecursivo(pPosicion++, auxLista, pString);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView2.Nodes.Count == 0) { treeView2.Nodes.Add("A"); treeView2.SelectedNode = treeView2.Nodes[0]; }
            else
            {
                try
                {
                    TreeNode tn = treeView2.SelectedNode;
                    if (tn.Nodes.Count < 2) { tn.Nodes.Add(Interaction.InputBox("¿Texto?:   ")); }
                    treeView2.ExpandAll();

                }catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Preorder(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Inorder(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Posorder(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            List<Nodo> L = new List<Nodo> { a };
            Anchura(L);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            treeView3.Nodes.Clear();

            List<Nodo> L = new List<Nodo>() { a };
            
            AnchuraConNull(L);

            StringToTree(textBox5.Text);

            CargaTreeView2(treeView3, StringToTree(textBox5.Text));
        }
    }

    public class Nodo
    {
        public Nodo() { Izq = null; Der = null; }
        public Nodo(string pTexto) : this() { texto = pTexto; }

        public string texto { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }


    }
}
