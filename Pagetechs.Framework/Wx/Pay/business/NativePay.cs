﻿using System;
using System.Collections.Generic;
using System.Web;

namespace Pagetechs.Framework.Wx.Pay.WxPayAPI
{
    public class NativePay
    {
        public NativePay()
        {
        }
        string appId = null;
        public NativePay(string appId)
        {
            this.appId = appId;
        }

        /**
        * 生成扫描支付模式一URL
        * @param productId 商品ID
        * @return 模式一URL
        */
        public string GetPrePayUrl(string productId)
        {
            Log.Info(this.GetType().ToString(), "Native pay mode 1 url is producing...");

            WxPayData data = new WxPayData();
            data.SetValue("appid", WxPayConfig.APPID);//公众帐号id
            data.SetValue("mch_id", WxPayConfig.MCHID);//商户号
            data.SetValue("time_stamp", WxPayApi.GenerateTimeStamp());//时间戳
            data.SetValue("nonce_str", WxPayApi.GenerateNonceStr());//随机字符串
            data.SetValue("product_id", productId);//商品ID
            data.SetValue("sign", data.MakeSign());//签名
            string str = ToUrlParams(data.GetValues());//转换为URL串
            string url = "weixin://wxpay/bizpayurl?" + str;

            Log.Info(this.GetType().ToString(), "Get native pay mode 1 url : " + url);
            return url;
        }

        /**
        * 生成直接支付url，支付url有效期为2小时,模式二
        * @param productId 商品ID
        * @return 模式二URL
        */
        public string GetPayUrl(Dictionary<string, string> dict)
        {
            Log.Info(this.GetType().ToString(), "Native pay mode 2 url is producing...");

            WxPayData data = new WxPayData();
            data.SetValue("body", dict["desc"]);//商品描述
            data.SetValue("attach", dict["name"]);//附加数据
            data.SetValue("out_trade_no", dict["out_trade_no"]);//随机字符串
            data.SetValue("total_fee", dict["fee"]);//总金额
            data.SetValue("time_start", DateTime.Now.ToString("yyyyMMddHHmmss"));//交易起始时间
            data.SetValue("time_expire", DateTime.Now.AddMinutes(10).ToString("yyyyMMddHHmmss"));//交易结束时间
            data.SetValue("goods_tag", dict["tag"]);//商品标记
            data.SetValue("trade_type", "NATIVE");//交易类型
            data.SetValue("product_id", dict["productId"]);//商品ID

            WxPayData result = WxPayApi.UnifiedOrder(data, dict["notify_url"]);//调用统一下单接口
            string url = result.GetValue("code_url").ToString();//获得统一下单接口返回的二维码链接

            Log.Info(this.GetType().ToString(), "Get native pay mode 2 url : " + url);
            return url;
        }

        /**
        * 参数数组转换为url格式
        * @param map 参数名与参数值的映射表
        * @return URL字符串
        */
        private string ToUrlParams(SortedDictionary<string, object> map)
        {
            string buff = "";
            foreach (KeyValuePair<string, object> pair in map)
            {
                buff += pair.Key + "=" + pair.Value + "&";
            }
            buff = buff.Trim('&');
            return buff;
        }
    }
}