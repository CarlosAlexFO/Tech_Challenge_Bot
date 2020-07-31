using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramChatBot

{
    class TelegramChatBot
    {
   
        private static readonly TelegramBotClient bot = new TelegramBotClient("Coloque aqui o TOKEN disponibilizado pelo Telegram, no Readm.");

      
        static void Main(string[] args)
        {
            bot.OnMessage += botmessage;
            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();

        }

        private static void botmessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                PrepareQuestionario(e);
        }
        public static void PrepareQuestionario(MessageEventArgs e)
        {


            if (e.Message.Text.ToLower() != "oi"
                && e.Message.Text.ToLower() != "olá"
                && e.Message.Text.ToLower() != "ola"
                 && e.Message.Text.ToLower() != "/start"
                && e.Message.Text.ToLower() != "eae")
            {
                if (!(!e.Message.Text.ToLower().Contains("promoção")
                               && !e.Message.Text.ToLower().Contains("promocao")
                               && !e.Message.Text.ToLower().Contains("promocoes")
                               && !e.Message.Text.ToLower().Contains("promocões")
                               && !e.Message.Text.ToLower().Contains("promoções")))

                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Sim, claro." +
                       Environment.NewLine + "Temos algumas promoções bacanas" +
                       Environment.NewLine + "Que talvez seja de seu interesse, segue o link" +
                       Environment.NewLine + "https://www.carrefoursolucoes.com.br/promocao");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("serviço")
                    && !e.Message.Text.ToLower().Contains("servico")
                    && !e.Message.Text.ToLower().Contains("servicos")
                    && !e.Message.Text.ToLower().Contains("serviços")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Organize sua vida com os serviços prestados pelo Cartão Carrefour " +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }


                else if (!(!e.Message.Text.ToLower().Contains("beneficios")
                    && !e.Message.Text.ToLower().Contains("beneficio")
                    && !e.Message.Text.ToLower().Contains("Beneficios")
                    && !e.Message.Text.ToLower().Contains("beneficio")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Temos beneficios como descontos exclusivos, parcelamento em 24X, parcelamentos em drogarias Carrefour, entre outros." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/cartao/beneficios#");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("saque") && !e.Message.Text.ToLower().Contains("saques")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Saque dinheiro no momento que precisar." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/web/guest/servicos/saque-rapido");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("cartao") 
                    && !e.Message.Text.ToLower().Contains("cartoes")
                     && !e.Message.Text.ToLower().Contains("Cartao")
                    && !e.Message.Text.ToLower().Contains("cartões")
                    && !e.Message.Text.ToLower().Contains("Cartões")
                    && !e.Message.Text.ToLower().Contains("Cartão")
                    && !e.Message.Text.ToLower().Contains("cartão")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Adquira seu cartão de Crédito Carrefour." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("Tarifas") 
                    && !e.Message.Text.ToLower().Contains("tarifas") 
                    && !e.Message.Text.ToLower().Contains("tarifa") 
                    && !e.Message.Text.ToLower().Contains("Tarifa")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Entenda o que são juros, encargos e tarifas." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/-/entenda-o-que-sao-juros-encargos-e-tarifas?redirect=https%3A%2F%2Fwww.carrefoursolucoes.com.br%2Fservicos%2Fsaque-rapido%3Fp_p_id%3D3%26p_p_lifecycle%3D0%26p_p_state%3Dmaximized%26p_p_mode%3Dview%26_3_groupId%3D0%26_3_groupId%3D0%26_3_keywords%3Dtarifas%26_3_keywords%3Dtarifas%26_3_struts_action%3D%252Fsearch%252Fsearch%26_3_struts_action%3D%252Fsearch%252Fsearch%26_3_redirect%3D%252Fweb%252Fguest%252Fservicos%252Fsaque-rapido%26_3_redirect%3D%252Fweb%252Fguest%252Fservicos%252Fsaque-rapido&inheritRedirect=true");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }


                else if (!(!e.Message.Text.ToLower().Contains("seguro") && !e.Message.Text.ToLower().Contains("seguros")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Proteja seus bens e o que é mais importante para você." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/seguros1");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("credito")
                    && !e.Message.Text.ToLower().Contains("Credito")
                    && !e.Message.Text.ToLower().Contains("Crédito")
                    && !e.Message.Text.ToLower().Contains("crédito")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Com este serviço realize todos os seus planos pendentes." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/credito-pessoal");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("pandemia") 
                    && !e.Message.Text.ToLower().Contains("corona") 
                    && !e.Message.Text.ToLower().Contains("virus") 
                    && !e.Message.Text.ToLower().Contains("vírus")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Com este serviço realize todos os seus planos pendentes." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://youtu.be/n8nSqfBwU4w");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("parcela") && !e.Message.Text.ToLower().Contains("parcelar") && !e.Message.Text.ToLower().Contains("parcele")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Escolha a melhor forma de pagar sua fatura." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos/parcele");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("sms") && !e.Message.Text.ToLower().Contains("celular")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Acompanhe suas compras pelo celular, através de SMS." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/sms-controle-total");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("pagcontas")
                    && !e.Message.Text.ToLower().Contains("contas")
                    && !e.Message.Text.ToLower().Contains("pagar contas")
                    && !e.Message.Text.ToLower().Contains("pagamento")
                    && !e.Message.Text.ToLower().Contains("luz")
                    && !e.Message.Text.ToLower().Contains("gas")
                    && !e.Message.Text.ToLower().Contains("agua")
                    && !e.Message.Text.ToLower().Contains("água")
                    && !e.Message.Text.ToLower().Contains("Contas")
                    && !e.Message.Text.ToLower().Contains("Conta")
                    && !e.Message.Text.ToLower().Contains("conta")
                    && !e.Message.Text.ToLower().Contains("pagamentos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Pague suas contas com o Cartão Carrefour." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos/pag-contas");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("atendimento")
                  && !e.Message.Text.ToLower().Contains("fale")
                  && !e.Message.Text.ToLower().Contains("central")
                  && !e.Message.Text.ToLower().Contains("ouvidoria")
                  && !e.Message.Text.ToLower().Contains("reclamação")
                  && !e.Message.Text.ToLower().Contains("reclamacao")
                  && !e.Message.Text.ToLower().Contains("autoatendimento")
                  && !e.Message.Text.ToLower().Contains("telefone")
                  && !e.Message.Text.ToLower().Contains("estande")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "AutoAtendimento, fale conosco." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/ouvidoria?inheritRedirect=true");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }


                else if (!(!e.Message.Text.ToLower().Contains("blog") 
                    && !e.Message.Text.ToLower().Contains("Blog")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Conheça o nosso Blog." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/blog");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("historia")
                    && !e.Message.Text.ToLower().Contains("carrefour") && !e.Message.Text.ToLower().Contains("sobre")
                    && !e.Message.Text.ToLower().Contains("banco")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Conheça a história do Banco Carrefour" +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/sobre");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");


                }

                else if (!(!e.Message.Text.ToLower().Contains("banco")
                    && !e.Message.Text.ToLower().Contains("video")
                    && !e.Message.Text.ToLower().Contains("apresentaçao")
                    && !e.Message.Text.ToLower().Contains("apresenta")
                    && !e.Message.Text.ToLower().Contains("apresentação")
                    && !e.Message.Text.ToLower().Contains("videos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Assista o video do Banco Carrefour." +
                        Environment.NewLine + "Mais detalhes no vídeo abaixo:" +
                        Environment.NewLine + "https://youtu.be/iSzCSSVzJ7Q");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("educaçao digital")
                    && !e.Message.Text.ToLower().Contains("treinamento")
                    && !e.Message.Text.ToLower().Contains("curso online")
                    && !e.Message.Text.ToLower().Contains("curso")
                    && !e.Message.Text.ToLower().Contains("educação")
                    && !e.Message.Text.ToLower().Contains("educacao")
                    && !e.Message.Text.ToLower().Contains("cursos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Aprenda e pratique gratuitamente as tecnologias mais usadas nas empresas em parceria com o Banco Carrefour" +
                        Environment.NewLine + "Mais detalhes, veja o vídeo:" +
                        Environment.NewLine + "https://youtu.be/5Uyk-o_N7G8");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }


                else if (!(!e.Message.Text.ToLower().Contains("fatura") 
                    && !e.Message.Text.ToLower().Contains("digital")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Seu cartão Carrefour conectado com você" +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/fatura-digital");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("lojas")
                    && !e.Message.Text.ToLower().Contains("loja")
                    && !e.Message.Text.ToLower().Contains("mercado")
                    && !e.Message.Text.ToLower().Contains("localizar")
                    && !e.Message.Text.ToLower().Contains("mercados")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Localize lojas próximas de você" +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/encontre-loja");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("desconto")
                   && !e.Message.Text.ToLower().Contains("Desconto")
                   && !e.Message.Text.ToLower().Contains("Descontos")
                   && !e.Message.Text.ToLower().Contains("descontos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Encontre descontos que irão agradar seu bolso" +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos?p_p_id=3&p_p_lifecycle=0&p_p_state=maximized&p_p_mode=view&_3_struts_action=%2Fsearch%2Fsearch&_3_redirect=%2Fservicos&_3_keywords=desconto&_3_groupId=0");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("boleto")
                  && !e.Message.Text.ToLower().Contains("Boleto")
                  && !e.Message.Text.ToLower().Contains("boletos")
                  && !e.Message.Text.ToLower().Contains("Boletos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Com este serviço do cartão de crédito, você paga todas as suas contas em uma única data." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos/pag-contas");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("acordo")
                 && !e.Message.Text.ToLower().Contains("boleto")
                 && !e.Message.Text.ToLower().Contains("dívidas")
                 && !e.Message.Text.ToLower().Contains("dividas")
                 && !e.Message.Text.ToLower().Contains("divida")
                 && !e.Message.Text.ToLower().Contains("boletos")
                 && !e.Message.Text.ToLower().Contains("acordos")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Recupere seu crédito, negocie sua dívida." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos?p_p_id=3&p_p_lifecycle=0&p_p_state=maximized&p_p_mode=view&_3_struts_action=%2Fsearch%2Fsearch&_3_redirect=%2Fservicos&_3_keywords=dividas&_3_groupId=0");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("quarentena")
                && !e.Message.Text.ToLower().Contains("Quarentena")
                && !e.Message.Text.ToLower().Contains("Corona virus")
                && !e.Message.Text.ToLower().Contains("corona virus")
                && !e.Message.Text.ToLower().Contains("coronavirus")))
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Muito além das compras. Dicas para quarentena." +
                        Environment.NewLine + "Mais detalhes, segue o link:" +
                        Environment.NewLine + "https://www.carrefoursolucoes.com.br/servicos?_3_formDate=1596166978971&p_p_id=3&p_p_lifecycle=0&p_p_state=maximized&p_p_mode=view&_3_struts_action=%2Fsearch%2Fsearch&_3_cur=1&_3_format=&_3_keywords=quarentena&_3_documentsSearchContainerPrimaryKeys=");
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Posso ajudá-lo em algo mais?");
                }

                else if (!(!e.Message.Text.ToLower().Contains("nao") && !e.Message.Text.ToLower().Contains("valeu") && !e.Message.Text.ToLower().Contains("não") && !e.Message.Text.ToLower().Contains("obrigado")))
                    bot.SendTextMessageAsync(e.Message.Chat.Id,
                        Environment.NewLine + "Carrefour Soluções Financeira agradece o seu contato!" +
                        Environment.NewLine + "Até a próxima!");
                else
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Desculpe, não localizado em nosso sistema!" +
                        Environment.NewLine + "Use palavras chaves, como por exemplo, saque, seguro, pague");
            }
            else bot.SendTextMessageAsync(e.Message.Chat.Id, "Olá" +
    Environment.NewLine + "Bem vindo ao Canal Carrefour Soluções Financeiras." +
    Environment.NewLine + "Para agilizar sua busca, digite apenas palavras chaves." +
    Environment.NewLine + "Por exemplo: saque, promoção, boleto, seguros." +
    Environment.NewLine + "Em que posso ajudá-lo?");
        }
     }
}








