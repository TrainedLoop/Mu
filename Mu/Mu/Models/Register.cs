using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Models
{
    public class Register
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            DateTime date = Convert.ToDateTime("21/05/2007");
            DateTime date2 = Convert.ToDateTime("23/11/2003 10:36:00");
            using ( var context  = new MuOnlineEntities()){
                VI_CURR_INFO newuserINFO = new VI_CURR_INFO
                {
                     ends_days="2005",
                     chek_code="1",
                     used_time=1234,
                     memb___id=Id,
                     memb_name="name",
                     memb_guid=1,
                     sno__numb="7",
                     Bill_Section=6,
                     Bill_Value=3,
                     Bill_Hour=6,
                     Surplus_Point=6,
                     Surplus_Minute=date2,
                     Increase_Days=0,                        

                };
var a = ("SET IDENTITY_INSERT MEMB_INFO ON")+
("INSERT INTO MEMB_INFO  (memb_guid,memb___id,memb__pwd,memb_name,sno__numb,post_code,addr_info,addr_deta,tel__numb,mail_addr,phon_numb,fpas_ques,fpas_answ,job__code,appl_days,modi_days,out__days,true_days,mail_chek,bloc_code,ctl1_code,vip,creditos,numero,frase,idade,sexo,localjogo,conexao)")+
("VALUES ('1','" + Id + "','$senhac','$nomec', '1','1234','11111','$numeroc','12343','$emailc','$emailc','$pergc','$respc','1','2007-21-05','2007-21-05','2007-21-05','2007-21-05','1','0','1','0','0','$numeroc','$frasec','$idadec','$sexoc','$localjogoc','$conexaoc')") +
("INSERT INTO VI_CURR_INFO (ends_days,chek_code,used_time,memb___id,memb_name,memb_guid,sno__numb,Bill_Section,Bill_value,Bill_Hour,Surplus_Point,Surplus_Minute,Increase_Days )  VALUES ('2005','1',1234,'$loginc','$nomec',1,'7','6','3','6','6','2003-11-23 10:36:00','0')");


            }
        }
    }
}