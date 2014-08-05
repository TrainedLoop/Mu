using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Mu.Repository;

namespace Mu.Repository.Maps
{


    public class MembInfoMap : ClassMap<MembInfo>
    {

        public MembInfoMap()
        {
            Table("MEMB_INFO");
            LazyLoad();
            Id(x => x.MembId).GeneratedBy.Assigned().Column("memb___id");
            Map(x => x.MembGuid).Column("memb_guid").Not.Nullable();
            Map(x => x.MembPwd).Column("memb__pwd").Not.Nullable();
            Map(x => x.MembName).Column("memb_name").Not.Nullable();
            Map(x => x.SnoNumb).Column("sno__numb").Not.Nullable();
            Map(x => x.PostCode).Column("post_code");
            Map(x => x.AddrInfo).Column("addr_info");
            Map(x => x.AddrDeta).Column("addr_deta");
            Map(x => x.TelNumb).Column("tel__numb");
            Map(x => x.PhonNumb).Column("phon_numb");
            Map(x => x.MailAddr).Column("mail_addr");
            Map(x => x.FpasQues).Column("fpas_ques");
            Map(x => x.FpasAnsw).Column("fpas_answ");
            Map(x => x.JobCode).Column("job__code");
            Map(x => x.ApplDays).Column("appl_days");
            Map(x => x.ModiDays).Column("modi_days");
            Map(x => x.OutDays).Column("out__days");
            Map(x => x.TrueDays).Column("true_days");
            Map(x => x.MailChek).Column("mail_chek");
            Map(x => x.BlocCode).Column("bloc_code").Not.Nullable();
            Map(x => x.Ctl1Code).Column("ctl1_code").Not.Nullable();
            Map(x => x.Vip).Column("vip").Not.Nullable();
            //Map(x => x.VipDate).Column("VipDate");
            Map(x => x.isAdm).Column("isAdm");
            Map(x => x.Creditos).Column("creditos").Not.Nullable();
        }
    }
}
