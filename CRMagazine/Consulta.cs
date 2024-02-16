﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Media;
using System.IO;

namespace CRMagazine
{
    class Consulta
    {
        Conexao cx = new Conexao();

        //SAP
        public string SAPDescricao = "";
        public string SAPCodPos = "";
        public string SAPTipo = "";

        //Varios=====
        public string Retorno = "";
        public string NumeroSerie = "";
        public string Modelo = "";
        public string Tipo = "";
        public string NFFaturamento = "";
        public string InicioGarantia = "";

        public string idChamados = "";
        public string NS = "";
        public string OS = "";
        public string Descricao = "";
        public string TipoEquip = "";
        public string SKU = "";
        public string NF = "";
        public string DtFatura = "";
        public string Meses = "";
        public string Orcamento = "";
        public string DtCompra = "";
        public string DtTroca = "";
        public string DiasTroca = "";
        public string DiasVistoria = "";
        public string DefeitoRelatado = "";
        public string Filial = "";
        public string ObsDocumento = "";
        public string NFVarejo = "";
        public string CodVarejo = "";
        public string NumLacre = "";
        public string Estetico = "";
        public string Funcional = "";
        public string ItensFaltantes = "";
        public string AcaoRetencao = "";
        public string ObsRetencao = "";
        public string Classificacao = "";
        public string ObsClassificacao = "";
        public string Varejista = "";
        public string Cidade = "";
        public string Responsavel = "";
        public string ChamadoPai = "";
        public string DtEntrada = "";
        public string IMEI1 = "";
        public string IMEI2 = "";
        public string Chamado = "";
        public string Status = "";
        public string DataA1 = "";
        public string StatusA1 = "";
        public string NotaFiscal = "";

        //=========== variaveis do banco Usuarios        
        public string idUsuario = "";
        public string Usuario = "";
        public string Senha = "";
        public string Entrada = "";
        public string Vistoria = "";
        public string Reparo = "";
        public string Runin = "";
        public string Expedicao = "";
        public string Consultas = "";
        public string Embalagem = "";
        public string Ajuste = "";
        public string ADM = "";
        public string Estoque = "";
        public string Versao = "";
        public string Assist = "";

        //=========== variaveis do banco Tecnica
        public string idTecnica = "";
        public string Tecnico = "";
        public string DataReparo = "";
        public string Defeito1 = "";
        public string CodPeca1 = "";
        public string DescPeca1 = "";
        public string SerialAntigo1 = "";
        public string SerialNovo1 = "";
        public string Defeito2 = "";
        public string CodPeca2 = "";
        public string DescPeca2 = "";
        public string SerialAntigo2 = "";
        public string SerialNovo2 = "";
        public string Defeito3 = "";
        public string CodPeca3 = "";
        public string DescPeca3 = "";
        public string SerialAntigo3 = "";
        public string SerialNovo3 = "";
        public string Defeito4 = "";
        public string CodPeca4 = "";
        public string DescPeca4 = "";
        public string SerialAntigo4 = "";
        public string SerialNovo4 = "";
        public string Defeito5 = "";
        public string CodPeca5 = "";
        public string DescPeca5 = "";
        public string SerialAntigo5 = "";
        public string SerialNovo5 = "";

        //=========== variaveis para Estoque

        public string Posicao = "";
        public string Quantidade = "";
        public int Contagem = 0;
        public string BareboneEquivalente = "";

        //=========== variavel para Consultar BaseCdigos   
        public string Codigo = "";
        public string idCod = "";
        public string Barebone = "";



        public string Coluna = "";
        public string ValorDesejado = "";
        public string ComData = "";
        public string ComCodPos = "";

        public string DataDesejada = "";


        public string comando = "";
        public string qntNaPosicao = "";

        //=========== variaveis para Impressao..
        public string produto = "";
      //  public string codPositivo = "";
      //  public string IMEI1 = "";
      //  public string IMEI2 = "";
      //  public string NS = "";
        public string EAN = "";
        public string Anatel = "";
        public string Config1 = "";
        public string Config2 = "";
        public string Config3 = "";
        public string Config4 = "";
        public string Config5 = "";
        public string Config6 = "";
        public string Config7 = "";
        public string Config8 = "";
        public string Config9 = "";
        public string Config10 = "";
        public string Config11 = "";
        public string TipoEtiqueta = "";
        public string IDImpressao = "";
        public string CodPositivo = "";
        public string DescricaoEan = "";

        public string ErroAssist = "";

        public void ConsultaTudo()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Chamados ";
                sql += " where " + Coluna + " = '" + ValorDesejado + "'";
                if (ComData == "SIM")
                {
                    sql += " and Status != 'FINALIZADO'";
                 //   sql += " and convert(varchar(10), DtEntrada, 103) like '%" + DataDesejada + "%'";
                    //limpa a variavel ComData
                    ComData = "";
                }
                
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    idChamados = dr["idChamados"].ToString();
                    OS = dr["OS"].ToString();
                    NS = dr["NS"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    TipoEquip = dr["TipoEquip"].ToString();
                    SKU = dr["SKU"].ToString();
                    //NF = dr["NF"].ToString();
                    //DtFatura = dr["DtFatura"].ToString();
                    //Meses = dr["Meses"].ToString();
                    //Orcamento = dr["Orcamento"].ToString();
                    DtCompra = dr["DtCompra"].ToString();
                    DtTroca = dr["DtTroca"].ToString();
                    //DiasTroca = dr["DiasTroca"].ToString();
                    //DiasVistoria = dr["DiasVistoria"].ToString();
                    DefeitoRelatado = dr["DefeitoRelatado"].ToString();
                    Filial = dr["Filial"].ToString();
                    ObsDocumento = dr["OBSDOCUMENTO"].ToString();
                    //NFVarejo = dr["NFVarejo"].ToString();
                    CodVarejo = dr["CodVarejo"].ToString();
                    NumLacre = dr["NumLacre"].ToString();
                    Estetico = dr["Estetico"].ToString();
                    Funcional = dr["Funcional"].ToString();
                    ItensFaltantes = dr["ItensFaltantes"].ToString();
                    //AcaoRetencao = dr["AcaoRetencao"].ToString();
                    //ObsRetencao = dr["ObsRetencao"].ToString();
                    Classificacao = dr["Classificacao"].ToString();
                    //ObsClassificacao = dr["ObsClassificacao"].ToString();
                    Varejista = dr["Varejista"].ToString();
                   // Cidade = dr["Cidade"].ToString();
                    Responsavel = dr["Responsavel"].ToString();
                    //ChamadoPai = dr["ChamadoPai"].ToString();
                    DtEntrada = dr["DataEntrada"].ToString();
                    //IMEI1 = dr["IMEI1"].ToString();
                    //IMEI2 = dr["IMEI2"].ToString();
                    //Chamado = dr["Chamado"].ToString();
                    Status = dr["Status"].ToString();
                    //Assist = dr["Assist"].ToString();
                    //ErroAssist = dr["ErroAssit"].ToString();
                    StatusA1 = dr["StatusA1"].ToString();
                    DataA1 = dr["DataA1"].ToString();
                    NotaFiscal = dr["NotaFiscal"].ToString();
                    Retorno = "ok";
                }
                else
                {
                    idChamados = "";
                    NS = "";
                    Descricao = "";
                    TipoEquip = "";
                    SKU = "";
                    NF = "";
                    DtFatura = "";
                    Meses = "";
                    Orcamento = "";
                    DtCompra = "";
                    DtTroca = "";
                    DiasTroca = "";
                    DiasVistoria = "";
                    DefeitoRelatado = "";
                    Filial = "";
                    ObsDocumento = "";
                    NFVarejo = "";
                    CodVarejo = "";
                    NumLacre = "";
                    Estetico = "";
                    Funcional = "";
                    ItensFaltantes = "";
                    AcaoRetencao = "";
                    ObsRetencao = "";
                    Classificacao = "";
                    ObsClassificacao = "";
                    Varejista = "";
                    Cidade = "";
                    Responsavel = "";
                    ChamadoPai = "";
                    DtEntrada = "";
                    IMEI1 = "";
                    IMEI2 = "";
                    Chamado = "";
                    Status = "";
                    ErroAssist = "";
                    Assist = "";
                    StatusA1 = "";
                    DataA1 = "";
                    NotaFiscal = "";
                    Retorno = "falha";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta CHAMADOS 'TUDO': \n" + x.Message);
            }
            cx.Desconectar();
        }

        public string Codigo_pre = "";
        public string Nota_pre = "";
        public void ConsultarPreEntrada(string RG)
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from PreEntrada ";
                sql += " where RG = '" + RG + "' ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Codigo_pre = dr["CodVarejo"].ToString();
                    Nota_pre = dr["Nota"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    Codigo_pre = "";
                    Nota_pre = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA AO CONSULTAR PRE ENTRADA: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public string NF_NotaFiscal = "";
        public string NF_Data = "";
        public string NF_Descricao = "";
        public string NF_Codigo = "";
        public string NF_EAN = "";
        public void ConsultaNotaFiscal(string Varejista, string Coluna, string Valor, string NF)
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from NotaFiscal ";
                sql += " where NotaFiscal in (" + NF + ") and Varejista = '" + Varejista + "' and " + Coluna + " = '" + Valor + "' ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    NF_NotaFiscal = dr["NotaFiscal"].ToString();
                    NF_Data = dr["Data"].ToString();
                    NF_Descricao = dr["Descricao"].ToString();
                    NF_Codigo = dr["CodVarejo"].ToString();
                    NF_EAN = dr["EAN"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    NF_NotaFiscal = "";
                    NF_Data = "";
                    NF_Descricao = "";
                    NF_Codigo = "";
                    NF_EAN = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA AO CONSULTAR NF DE ENTRADA: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public string NF_NotaFiscal_Saida = "";
        public string NF_Data_Saida = "";
        public string NF_Descricao_Saida = "";
        public string NF_Codigo_Saida = "";
        public string NF_EAN_Saida = "";
        public void ConsultaNotaFiscalSaida(string Varejista, string Coluna, string Valor, string NF)
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from ConfereNFSaida ";
                sql += " where NotaFiscal in (" + NF + ") and Varejista = '" + Varejista + "' and " + Coluna + " = '" + Valor + "' ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    NF_NotaFiscal_Saida = dr["NotaFiscal"].ToString();
                    NF_Data_Saida = dr["Data"].ToString();
                    NF_Descricao_Saida = dr["Descricao"].ToString();
                    NF_Codigo_Saida = dr["CodVarejo"].ToString();
                    NF_EAN_Saida = dr["EAN"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    NF_NotaFiscal_Saida = "";
                    NF_Data_Saida = "";
                    NF_Descricao_Saida = "";
                    NF_Codigo_Saida = "";
                    NF_EAN_Saida = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA AO CONSULTAR NF DE SAIDA: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public string EANpuri = "";
        public void ConsultarCodVarejo(string valor, string Varejista)
        {
            try
            {
                if (Varejista.Contains("MAGAZINE")) //FEITO PARA NÃO PRACISAR FICAR CADASTRANDO MAGAZINE POR MAGAZINE (NÃO PRECISAR REPLICAR CÓDIGO)
                {
                    Varejista = "MAGAZINE";
                }
                Retorno = "";
                string sql = "";
                sql += " Select * from CodVarejo ";
                sql += " where CodVarejo = '" + valor + "' and Varejista = '" + Varejista + "' ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Descricao = dr["Descricao"].ToString();
                    SKU = dr["SKU"].ToString();
                    TipoEquip = dr["TipoEquip"].ToString();
                    EANpuri = dr["EAN"].ToString();
                    Varejista = dr["Varejista"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    Descricao = "";
                    SKU = "";
                    TipoEquip = "";
                    EANpuri = "";
                    Varejista = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA AO CONSULTAR CODVAREJO: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void ConsultarEAN(string coluna, string valor, string porVarejista) // SE O POR VAREJISTA FOR DIFERENTE DE NÃO, O SISTEMA BUSCA PELO NOME DO VAREJISTA TMB
        {
            try
            {
                if (porVarejista.Contains("MAGAZINE")) //FEITO PARA NÃO PRACISAR FICAR CADASTRANDO MAGAZINE POR MAGAZINE (NÃO PRECISAR REPLICAR CÓDIGO)
                {
                    porVarejista = "MAGAZINE";
                }
                Retorno = "";
                string sql = "";
                sql += " Select * from CodVarejo ";
                sql += " where " + coluna + " = '" + valor + "'";
                if (porVarejista != "NÃO")
                {
                    sql += " and varejista = '" + porVarejista + "'";
                }               
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Descricao = dr["Descricao"].ToString();
                    CodVarejo = dr["CodVarejo"].ToString();
                    SKU = dr["SKU"].ToString();
                    TipoEquip = dr["TipoEquip"].ToString();
                    EANpuri = dr["EAN"].ToString();

                }
                else
                {
                    Retorno = "falha";
                    Descricao = "";
                    CodVarejo = "";
                    SKU = "";
                    TipoEquip = "";
                    EANpuri = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA AO CONSULTAR CODVAREJO: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public string DNP;
        public void ConsultarDatas(string DataDesejada, string ChamadoDT)
        {
            try
            {
                string sql = "";
                sql += "select DATEDIFF(DAY, " + DataDesejada + " , GETDATE()) as DNP from CHAMADOS where chamado = '" + ChamadoDT + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    DNP = dr["DNP"].ToString();             
                    Retorno = "ok";
                }
                else
                {
                   Retorno = "falha";
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("FALHA CALCULAR DATAS:\r\n" + x.Message);
            }
            cx.Desconectar();            
        }

        public void consultarTecnica()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from SalvarTecnica ";
                sql += " where Chamado = '" + Chamado + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    //idTecnica = dr["idTecnica"].ToString();
                    Tecnico = dr["Tecnico"].ToString();
                    Chamado = dr["Chamado"].ToString();
                    NumeroSerie = dr["NumeroSerie"].ToString();
                    DataReparo = dr["DataReparo"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    Defeito1 = dr["Defeito1"].ToString();
                    CodPeca1 = dr["CodPeca1"].ToString();
                    DescPeca1 = dr["DescPeca1"].ToString();
                    SerialAntigo1 = dr["SerialAntigo1"].ToString();
                    SerialNovo1 = dr["SerialNovo1"].ToString();
                    Defeito2 = dr["Defeito2"].ToString();
                    CodPeca2 = dr["CodPeca2"].ToString();
                    DescPeca2 = dr["DescPeca2"].ToString();
                    SerialAntigo2 = dr["SerialAntigo2"].ToString();
                    SerialNovo2 = dr["SerialNovo2"].ToString();
                    Defeito3 = dr["Defeito3"].ToString();
                    CodPeca3 = dr["CodPeca3"].ToString();
                    DescPeca3 = dr["DescPeca3"].ToString();
                    SerialAntigo3 = dr["SerialAntigo3"].ToString();
                    SerialNovo3 = dr["SerialNovo3"].ToString();
                    Defeito4 = dr["Defeito4"].ToString();
                    CodPeca4 = dr["CodPeca4"].ToString();
                    DescPeca4 = dr["DescPeca4"].ToString();
                    SerialAntigo4 = dr["SerialAntigo4"].ToString();
                    SerialNovo4 = dr["SerialNovo4"].ToString();
                    Defeito5 = dr["Defeito5"].ToString();
                    CodPeca5 = dr["CodPeca5"].ToString();
                    DescPeca5 = dr["DescPeca5"].ToString();
                    SerialAntigo5 = dr["SerialAntigo5"].ToString();
                    SerialNovo5 = dr["SerialNovo5"].ToString();
                    Status = dr["Status"].ToString();
                                      

                    Retorno = "ok";
                }
                else
                {
                    Retorno = "falha";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta USUARIOS: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void consultarUsuario()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Usuarios ";
                sql += " where Usuario = '" + Usuario + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    idUsuario = dr["idUsuario"].ToString();
                    Usuario = dr["Usuario"].ToString();
                    Senha = dr["Senha"].ToString();
                    Entrada = dr["Entrada"].ToString();
                    Vistoria = dr["Vistoria"].ToString();
                    Reparo = dr["Reparo"].ToString();
                    Runin = dr["Runin"].ToString();
                    Expedicao = dr["Expedicao"].ToString();
                    Consultas = dr["Consultas"].ToString();
                    Embalagem = dr["Embalagem"].ToString();
                    Ajuste = dr["Ajuste"].ToString();
                    ADM = dr["ADM"].ToString();
                    Estoque = dr["Estoque"].ToString();
                    Assist = dr["Assist"].ToString();
                    Versao = dr["Versao"].ToString();
                    Retorno = "ok";
                }
                else
                {
                    idUsuario = "";
                    Usuario = "";
                    Senha = "";
                    Entrada = "";
                    Vistoria = "";
                    Reparo = "";
                    Runin = "";
                    Expedicao = "";
                    Consultas = "";
                    Embalagem = "";
                    Ajuste = "";
                    Estoque = "";
                    Assist = "";
                    Versao = "";
                    Retorno = "falha";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta USUARIOS: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void ConsultarNSEQUISAP()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " select SERNR, MATNR, EQKTX, EQART, TIDNR, REM_NFENUM, GWLDT from equi where serge = '" + NumeroSerie + "' ";

                if (ComCodPos.Length > 0)
                {
                    sql += " and MATNR like '%" + ComCodPos + "%'";
                    
                    ComCodPos = "";
                }

                cx.ConectarSAP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Modelo = dr["EQKTX"].ToString();
                    Tipo = dr["EQART"].ToString();

                    SAPDescricao = dr["EQKTX"].ToString();
                    SAPCodPos = dr["MATNR"].ToString();
                    SAPTipo = dr["EQART"].ToString();
                    NFFaturamento = dr["REM_NFENUM"].ToString();
                    InicioGarantia = dr["GWLDT"].ToString(); // inicio da garantia (qq coisa deve ser tirado o erdat e colocar o gwldt no select)
                    //  InicioGarantia = dr["ERDAT"].ToString(); // ERDAT = DATA DA FABRICAÇÃO (qq coisa deve ser tirado o gwldt e colocar o ERDAT no select)
                }
                else
                {
                    Retorno = "falha";
                    Modelo = "";
                    Tipo = "";
                    SAPDescricao = "";
                    SAPCodPos = "";
                    SAPTipo = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA EM CONSULTA EQUI SAP: \n" + x.Message);
            }
            cx.Desconectar();

        }

        public void consultarBaseCodigos(string Codigo)
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from BaseCodigos ";
                sql += " where Codigo = '" + Codigo + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    // idCod = dr["idCod"].ToString();
                    Codigo = dr["Codigo"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    SKU = dr["SKU"].ToString();
                    Categoria = dr["Categoria"].ToString();
                    Localizacao = dr["Localizacao"].ToString();
                    Preco = dr["Preco"].ToString();
                    Retorno = "ok";
                }
                else
                {
                    Retorno = "falha";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta USUARIOS: \n" + x.Message);
            }
            cx.Desconectar();
        }
        

        public void InsereNoBanco(
            string OS,
            string CodVarejo,
            string Descricao,
            string SKU,
            string DataEntrada,
            string Status,
            string TipoEquip,
            string Varejista,
            string NS,
            string DefeitoRelatado,
            string Filial,
            string DataGaiola

            )
        {
            Retorno = "";
            string sql = "";
            try
            {
                sql += "IF NOT EXISTS (select * from Chamados where OS = '" + OS + "') BEGIN ";
                sql += "insert into Chamados (OS, CodVarejo, Descricao, SKU, DataEntrada, Status, TipoEquip, Varejista, NS, DefeitoRelatado, Filial, DataGaiola) values ";  
                sql += "(";
                sql += "'" + OS + "', ";
                sql += "'" + CodVarejo + "', ";
                sql += "'" + Descricao + "', ";
                sql += "'" + SKU + "', ";
                sql += "'" + DataEntrada + "', ";
                sql += "'" + Status + "', ";
                sql += "'" + TipoEquip + "', ";
                sql += "'" + Varejista + "', ";
                sql += "'" + NS + "', ";
                sql += "'" + DefeitoRelatado + "', ";
                sql += "'" + Filial + "', ";
                sql += "'" + DataGaiola + "'";
                sql += ")";
                sql += " END";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR NO BANCO CHAMADOS: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }

        public string OSoutros = "";
        public void InsereNoBancoOutros(
            //string OS,
            string CodVarejo,
            string Descricao,
            string SKU,
            string DataEntrada,
            string Status,
            string TipoEquip,
            string Varejista,
            string NS,
            string DefeitoRelatado,
            string Filial,
            string DataGaiola
            )
        {
            OSoutros = "";
            Retorno = "";
            string sql = "";
            int id = 0;
            
            try
            {
                sql += "IF NOT EXISTS (select * from Chamados where OS = (select 'JB' + convert(varchar(15),(MAX(idChamados)+1)) from Chamados)) BEGIN ";
                sql += "insert into Chamados (OS, CodVarejo, Descricao, SKU, DataEntrada, Status, TipoEquip, Varejista, NS, DefeitoRelatado, Filial, DataGaiola) ";
                sql += "(";
                sql += "select 'JB' + convert(varchar(15),(MAX(idChamados)+1)), ";
                sql += "'" + CodVarejo + "', ";
                sql += "'" + Descricao + "', ";
                sql += "'" + SKU + "', ";
                sql += "'" + DataEntrada + "', ";
                sql += "'" + Status + "', ";
                sql += "'" + TipoEquip + "', ";
                sql += "'" + Varejista + "', ";
                sql += "'" + NS + "', ";
                sql += "'" + DefeitoRelatado + "', ";
                sql += "'" + Filial + "', ";
                sql += "'" + DataGaiola + "'";
                sql += " from Chamados) END";                
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();

                cd.CommandText = "SELECT SCOPE_IDENTITY()";
                id = Convert.ToInt32(cd.ExecuteScalar());

                // OS GERADA NO CHAMADOS PARA INSERIR NO HISTORICO
                OSoutros = "JB" + id;

                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR NO BANCO CHAMADOS USANDO OUTROS VAREJISTAS: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();           
        }


        public void InsereNoBancoDATA(
           string NS, string Descricao, string Tipo, string SKU, string NF, string DtFatura, string Meses, string Orcamento,
           DateTime DtCompra, DateTime DtTroca, string DiasTroca, string DiasVistoria, string DefeitoRelatado, string Filial, string ObsDocumento,
           string NFVarejo, string CodVarejo, string NumLacre,
           string Estetico, string Funcional, string ItensFaltantes, string AcaoRetencao, string ObsRetencao, string Classificacao, string Doa_NaoDoa, string ObsClassificacao,
           string Varejista, string CidadeVarejista, string Responsavel, string ChamadoPai, DateTime DtEntrada, string IMEI1, string IMEI2, string Chamado)
        {
            Retorno = "";
            string sql = "";
            try
            {

                //  sql += "insert into Chamados (NS, Descricao, Tipo, SKU, NF, DtFatura, Meses, Orcamento, DtCompra, DtTroca, DiasTroca, DiasVistoria, DefeitoRelatado, Filial, ObsDocumento, NFVarejo, CodVarejo, NumLacre, Estetico, Funcional, ItensFaltantes, AcaoRetencao, ObsRetencao, Classificacao, Varejista, Responsavel, ChamadoPai, DtEntrada) values ";
                sql += "insert into PSREXTERNO_CHAMADOS (NS, Descricao, Tipo, SKU, NF, DtFatura, Meses, Orcamento, DtCompra, DtTroca, DiasTroca, DiasVistoria, DefeitoRelatado, Filial, ObsDocumento, NFVarejo, CodVarejo, NumLacre, Classificacao, Doa_NaoDoa, ObsClassificacao, Varejista, Cidade, Responsavel, ChamadoPai, DtEntrada, IMEI1, IMEI2, Chamado) values ";
                sql += "('" + NS + "', '" + Descricao + "', '" + Tipo + "', '" + SKU + "', '" + NF + "', '" + DtFatura + "', '" + Meses + "', '" + Orcamento + "', ";
                sql += "'" + DtCompra + "', '" + DtTroca + "', '" + DiasTroca + "', '" + DiasVistoria + "', '" + DefeitoRelatado + "', '" + Filial + "', '" + ObsDocumento + "', ";
                sql += "'" + NFVarejo + "', '" + CodVarejo + "', '" + NumLacre + "', ";
                sql += "'" + Estetico + "', '" + Funcional + "', '" + ItensFaltantes + "', '" + AcaoRetencao + "', '" + ObsRetencao + "', '" + Classificacao + "', '" + Doa_NaoDoa + "','" + ObsClassificacao + "', ";
                sql += "'" + Varejista + "', '" + CidadeVarejista + "', '" + Responsavel + "', '" + ChamadoPai + "', '" + DtEntrada + "', '" + IMEI1 + "', '" + IMEI2 + "', 'PENDENTE'";
                sql += ")";

                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR NO BANCO CHAMADOS: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }


        public string data = "";
        public string dataNormal = "";
        public string dataCompleta = "";
        public string hora = "";
        public string datainteira = "";
        public string dataParaArquivo = "";
        public string dataInvertida = "";
        public string dataInvertidaComtraço = "";

        public void DataAtual()
        {
            try
            {
                string sql = "";
                sql += "select convert(datetime, getdate(), 113) as data";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    //data = dr["data"].ToString();
                    datainteira = dr["data"].ToString();
                    //Retorno = "ok";
                }
                else
                {
                    // Retorno = "falha";
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("FALHA AOU CONSULTAR HORA DO SERVIDOR:\r\n" + x.Message);
            }
            cx.Desconectar();
            DateTime agora = Convert.ToDateTime(datainteira);
            data = agora.ToString("MM/dd/yyyy");
            dataInvertida = agora.ToString("yyyy/MM/dd");
            dataInvertidaComtraço = agora.ToString("yyyy-MM-dd");
            dataNormal = agora.ToString("dd/MM/yyyy");
            dataParaArquivo = agora.ToString("dd-MM-yyyy");
           // data = agora.ToString("dd/MM/yyyy");
            dataCompleta = agora.ToString();
            hora = agora.ToString("HH:mm");
        }

        public int cont;
        public void consultarHistorico()
        {
            cont = 0;
            try
            {
                Retorno = "";
                string sql = "";
                sql = comando;
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cont = (Int32)cd.ExecuteScalar();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em consultar Historico: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void PlayFail()
        {
            SoundPlayer myPlayer = new SoundPlayer(CRMagazine.Properties.Resources.FAIL);
            myPlayer.Play();
        }

        public void PlayOK()
        {
            SoundPlayer myPlayer = new SoundPlayer(CRMagazine.Properties.Resources.OK);
            myPlayer.Play();
        }


        public void Atualizar()
        {
            Retorno = "";
            string sql = "";
            //string status = "RUNIN";
            //DateTime agora = DateTime.Now;
            //string data = agora.ToString();
            //string Historico = txtHistorico.Text + " | REPARO: " + data;
            try
            {
                sql += comando;
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO ATUALIZAR: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }

        public void AtualizarSP()
        {
            Retorno = "";
            string sql = "";
            //string status = "RUNIN";
            //DateTime agora = DateTime.Now;
            //string data = agora.ToString();
            //string Historico = txtHistorico.Text + " | REPARO: " + data;
            try
            {
                sql += comando;
                cx.ConectarSP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO ATUALIZAR: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }

        public void InsereHistorico(string OS, string Usuario, string Status, string Data, string Hora)
        {
            Retorno = "";
            string sql = "";
            try
            {
                sql += "insert into Historico (OS, Usuario, Status, Data, Hora) values ";
                sql += "('" + OS + "', '" + Usuario + "', '" + Status + "', '" + Data + "', '" + Hora + "')";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR EM HISTORICO: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }


        public string senha = "";
        public void ConferirLogar()
        {
            try
            {
                string sql = "";
                sql += " Select Senha From Usuarios ";
                sql += " Where Usuario = 'Master' ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    senha = dr["Senha"].ToString();
                }
                else
                {
                    MessageBox.Show("Usuario não Cadastrado");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
            cx.Desconectar();
        }

        public void consultarSimNao()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += comando;
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    qntNaPosicao = dr["Quantidade"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    qntNaPosicao = "0";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em consultarSimNao: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void consultarImpressao()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from PSREXTERNO_ETIQUETAS ";
                sql += " where CodPositivo = '" + CodPositivo + "'";
                cx.ConectarEtq();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    IDImpressao = dr["IDImpressao"].ToString();
                    TipoEtiqueta = dr["TipoEtiqueta"].ToString();
                   // CodViaVarejo = dr["CodViaVarejo"].ToString();
                    CodPositivo = dr["CodPositivo"].ToString();
                    EAN = dr["EAN"].ToString();
                    DescricaoEan = dr["Descricao"].ToString();
                    Anatel = dr["Anatel"].ToString();
                    Config1 = dr["Config1"].ToString();
                    Config2 = dr["Config2"].ToString();
                    Config3 = dr["Config3"].ToString();
                    Config4 = dr["Config4"].ToString();
                    Config5 = dr["Config5"].ToString();
                    Config6 = dr["Config6"].ToString();
                    Config7 = dr["Config7"].ToString();
                    Config8 = dr["Config8"].ToString();
                    Config9 = dr["Config9"].ToString();
                    Config10 = dr["Config10"].ToString();
                    Config11 = dr["Config11"].ToString();
                    Retorno = "ok";
                }
                else
                {
                    Retorno = "falha";
                    TipoEtiqueta = "nada";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta EXPEDICAO: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public string CodPeca = "";
        public string DescricaoPeca = "";
        public string Preco = "";
        public string Categoria = "";
        public string Localizacao = "";

        public void ConsultarPreco(string comando)
        {
            try
            {
                Retorno = "";
                string sql = "";
                //Exemplo sql += " Select * from Precos where CodPeca = '" + ConsultarChamado + "'";
                sql = comando;
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";                    
                    CodPeca = dr["Codigo"].ToString();
                    DescricaoPeca = dr["Descricao"].ToString();
                    SKU = dr["SKU"].ToString();
                    Categoria = dr["Categoria"].ToString();
                    Localizacao = dr["Localizacao"].ToString();
                    Preco = dr["Preco"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    CodPeca = "";
                    DescricaoPeca = "";
                    SKU = "";
                    Categoria = "";
                    Localizacao = "";
                    Preco = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta pelo Chamado: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void InserePreco(string CodPeca, string DescricaoPeca, string SKU, string Categoria, string Localizacao, string Preco)
        {
            Retorno = "";
            string sql = "";
            try
            {
                sql += "insert into BaseCodigos (Codigo, Descricao, SKU, Categoria, Localizacao, Preco) values ";
                sql += "('" + CodPeca + "', '" + DescricaoPeca + "', '" + SKU + "', '" + Categoria + "', '" + Localizacao + "', '" + Preco + "')";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR PREÇOS: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }


        public void ContarEstoque()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Estoque ";
                sql += " where Codigo = '" + Codigo + "' and Posicao != 'PP'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                Contagem = 0;
                while (dr.Read())
                {
                    Descricao = dr["Descricao"].ToString();
                    Quantidade = dr["Quantidade"].ToString();
                    Contagem = Convert.ToInt32(Quantidade) + Contagem;
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Contar ESTOQUE: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void ContarEmPedidos()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Pedidos ";
                sql += " where Status = 'AGUARDANDO' and Codigo = '" + Codigo + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                Contagem = 0;
                while (dr.Read())
                {
                    Quantidade = dr["Quantidade"].ToString();
                    Contagem = Convert.ToInt32(Quantidade) + Contagem;
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em ContarEmPedidos: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void consultarEstoque()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Estoque ";
                sql += " where Codigo = '" + Codigo + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    idCod = dr["idCod"].ToString();
                    Codigo = dr["Codigo"].ToString();
                    Barebone = dr["Barebone"].ToString();
                    BareboneEquivalente = dr["BareboneEquivalente"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    Quantidade = dr["Quantidade"].ToString();
                    Posicao = dr["Posicao"].ToString();
                    Chamado = dr["Chamado"].ToString();
                    Tipo = dr["Tipo"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    idCod = "";
                    Codigo = "";
                    Barebone = "";
                    Descricao = "";
                    Quantidade = "";
                    BareboneEquivalente = "";
                    Tipo = "";
                    Posicao = "";
                    Chamado = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta ESTOQUE: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void InserirClientes(string Nome, string CPF, string Endereco, string Bairro, string Cidade, string Telefone, string EmailPessoal)
        {
            string sql = "";
            try
            {
                sql = "insert into Clientes (Nome, CPF, Endereco, Bairro, Cidade, Telefone, EmailPessoal) values ";
                sql += " ('" + Nome + "', '" + CPF + "',  ";
                sql += " '" + Endereco + "', '" + Cidade + "', '" + Bairro + "', '" + Telefone + "', '" + EmailPessoal + "') ";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";

                //Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR EM CLIENTES: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }

        public string idClientes = "";
        public string Nome = "";
        public string CPF = "";
        public string Endereco = "";
        public string CidadeCliente = "";
        public string Bairro = "";
        public string Telefone = "";        
        public string EmailPessoal = "";
       

        public void consultarClientes(string Coluna, string TextoDesejado)
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from CLientes ";
                sql += " where " + Coluna + " = '" + TextoDesejado + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    idClientes = dr["idCLientes"].ToString();
                    Nome = dr["Nome"].ToString();
                    CPF = dr["CPF"].ToString();       
                    Endereco = dr["Endereco"].ToString();
                    Bairro = dr["Bairro"].ToString();
                    CidadeCliente = dr["Cidade"].ToString();
                    Telefone = dr["Telefone"].ToString();                   
                    EmailPessoal = dr["EmailPessoal"].ToString();                  
                    Retorno = "ok";
                }
                else
                {
                    idClientes = "";
                    Nome = "";
                    CPF = "";
                    Endereco = "";
                    CidadeCliente = "";
                    Bairro = "";
                    Telefone = "";                  
                    EmailPessoal = "";                   
                    Retorno = "falha";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta CLIENTES: \n" + x.Message);
            }
            cx.Desconectar();
        }




        public void ContarEstoqueSP()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Estoque ";
                sql += " where Codigo = '" + Codigo + "' and Posicao != 'PP'";
                cx.ConectarSP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                Contagem = 0;
                while (dr.Read())
                {
                    Descricao = dr["Descricao"].ToString();
                    Quantidade = dr["Quantidade"].ToString();
                    Contagem = Convert.ToInt32(Quantidade) + Contagem;
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Contar ESTOQUE: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void ContarEmPedidosSP()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Pedidos ";
                sql += " where Status = 'AGUARDANDO' and Codigo = '" + Codigo + "'";
                cx.ConectarSP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                Contagem = 0;
                while (dr.Read())
                {
                    Quantidade = dr["Quantidade"].ToString();
                    Contagem = Convert.ToInt32(Quantidade) + Contagem;
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em ContarEmPedidos: \n" + x.Message);
            }
            cx.Desconectar();
        }


        public void ContarEmPedidosMagazineSP()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from MovimentacaoEstoque ";
                sql += " where Status = 'AGUARDANDO' and Codigo = '" + Codigo + "'";
                cx.ConectarSP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                Contagem = 0;
                while (dr.Read())
                {
                    Quantidade = dr["Quantidade"].ToString();
                    Contagem = Convert.ToInt32(Quantidade) + Contagem;
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em ContarEmPedidos: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void consultarEstoqueSP()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Estoque ";
                sql += " where Codigo = '" + Codigo + "'";
                cx.ConectarSP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    idCod = dr["idCod"].ToString();
                    Codigo = dr["Codigo"].ToString();
                    Barebone = dr["Barebone"].ToString();
                    BareboneEquivalente = dr["BareboneEquivalente"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    Quantidade = dr["Quantidade"].ToString();
                    Posicao = dr["Posicao"].ToString();
                    Chamado = dr["Chamado"].ToString();
                    Tipo = dr["Tipo"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    idCod = "";
                    Codigo = "";
                    Barebone = "";
                    Descricao = "";
                    Quantidade = "";
                    BareboneEquivalente = "";
                    Tipo = "";
                    Posicao = "";
                    Chamado = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta ESTOQUE: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public string TIPO_ESPC = "";
        public string COD_ESPC = "";
        public void ConsultarCodigoSAP()
        {
            Tipo = "";
            TIPO_ESPC = "";
            COD_ESPC = "";

            try
            {
                Retorno = "";
                string sql = "";
                //sql += " select MATNR AS 'Codigo', MAKTX AS 'Descricao' from MARA where MATNR like '%" + Codigo + "'";
                sql += " select convert(numeric,MATNR) AS 'Codigo', ";
                sql += " MAKTX AS 'Descricao', ";
                sql += " MARA.MATKL AS 'TIPO', ";
                sql += " WGBEZ AS 'TIPO_ESPC', ";
                sql += " WGBEZ60 AS 'COD_ESPC' ";
                sql += " FROM MARA (NOLOCK) AS MARA ";
                sql += " INNER JOIN T023T (NOLOCK) AS T023T ";
                sql += " ON MARA.MATKL = T023T.MATKL ";
                sql += " and MATNR like '%" + Codigo + "' ";


                cx.ConectarSAP();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Codigo = dr["Codigo"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    Tipo = dr["TIPO"].ToString();
                    TIPO_ESPC = dr["TIPO_ESPC"].ToString();
                    COD_ESPC = dr["COD_ESPC"].ToString();
                }
                else
                {

                    Retorno = "falha";
                    Codigo = "";
                    Descricao = "";
                    Tipo = "";
                    TIPO_ESPC = "";
                    COD_ESPC = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("FALHA EM CONSULTA CODIGO SAP: \n" + x.Message);
            }
            cx.Desconectar();

        }

        public string ConsultarChamado = "";

        public void ConsultarPeloChamado()
        {
            try
            {
                Retorno = "";
                string sql = "";
                sql += " Select * from Chamados ";
                sql += " where OS = '" + ConsultarChamado + "'";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = "ok";
                    Status = dr["Status"].ToString();
                    ///   OSViaVarejo = dr["OSViaVarejo"].ToString();
                    //   AguardoPeca = dr["AGUARDOPECA"].ToString();
                }
                else
                {
                    Retorno = "falha";
                    Status = "nada";
                    //      OSViaVarejo = "";
                    //     AguardoPeca = "";
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Falha em Consulta pelo Chamado: \n" + x.Message);
            }
            cx.Desconectar();
        }

        public void LimparControles(Control parent)
        {
            foreach (Control cont in parent.Controls)
            {
                if (cont is TextBox)
                {
                    if ((cont as TextBox).Name != "txtTriador" && (cont as TextBox).Name != "txtDataDesejadaNaoLimpar" && (cont as TextBox).Name != "txtCidadeVarejista" && (cont as TextBox).Name != "txtPrazoTroca" && (cont as TextBox).Name != "txtTrocaCel" && (cont as TextBox).Name != "txtTrocaInfo" && (cont as TextBox).Name != "txtEndereco")
                    {
                        (cont as TextBox).Text = "";
                        cont.BackColor = ((TextBox)cont).ReadOnly
                           ? System.Drawing.SystemColors.Control
                           : System.Drawing.SystemColors.Window;
                    }
                    
                }

                if (cont is MaskedTextBox)
                {
                    if ((cont as MaskedTextBox).Name != "mtbDataGaiola")
                    {
                        (cont as MaskedTextBox).Text = "";
                        cont.BackColor = ((MaskedTextBox)cont).ReadOnly
                           ? System.Drawing.SystemColors.Control
                           : System.Drawing.SystemColors.Window;
                    }                   
                }

                if (cont is ComboBox) 
                {
                    if ((cont as ComboBox).Name != "cboVarejista" && (cont as ComboBox).Name != "cboUsuario" && (cont as ComboBox).Name != "cboNotaFiscal")
                    {
                        (cont as ComboBox).Text = "";
                    }                    
                }

                if (cont is DateTimePicker) { (cont as DateTimePicker).Text = ""; }

               // if (cont is MaskedTextBox) { (cont as MaskedTextBox).Text = ""; }

                if ((cont is RadioButton) && (cont as RadioButton).Name != "rbt200dpi" && (cont as RadioButton).Name != "rbt300dpi" && (cont as RadioButton).Name != "rbt600dpi" && (cont as RadioButton).Name != "rbt110" && (cont as RadioButton).Name != "rbt220" && (cont as RadioButton).Name != "rbtBIv")
                {                     
                    (cont as RadioButton).Checked = false;
                }

                if ((cont is CheckBox) && (cont as CheckBox).Name != "chbSelecionarImpressora" && (cont as CheckBox).Name != "chbNaoImprimir" && (cont as CheckBox).Name != "chbSemConexao" && (cont as CheckBox).Name != "chbSemZebra" && (cont as CheckBox).Name != "chbIrParaReparo" && (cont as CheckBox).Name != "chbSemA1" && (cont as CheckBox).Name != "chbConfigImpressora")
                { 
                    (cont as CheckBox).Checked = false;
                }

                if (cont is CheckedListBox)
                {
                    foreach (ListControl item in (cont as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }

                if (cont is ListBox)
                {
                    if ((cont as ListBox).Name != "lstContagem")
                    {
                        (cont as ListBox).Items.Clear(); 
                    }
                    
                }

                if (cont is ListView) { (cont as ListView).Items.Clear(); }

                // varre os filhos...
                this.LimparControles(cont);
            }
        }



    }
}
