
import json
import urllib.request

#--------------------------------------------
# ��ȡjson����-------------------------------
#--------------------------------------------
#��ʽһ����api��ȡJSON
# bdUrl="https://finance.pae.baidu.com/selfselect/getstockquotation?code=000300&all=1&ktype=2&isIndex=true&isBk=false&isBlock=false&stockType=ab&market_type=ab&group=quotation_index_kline&finClientType=pc" 

# with urllib.request.urlopen(bdUrl) as url:

#     data = json.loads(url.read().decode())


#��ʽ������json�ļ���ȡjson����
with open('file.json') as f:

    data = json.load(f)

# print(data)
print(data['Result'][-1]['ma20']['avgPrice']) 
# print(data['QueryID']) 

 

#--------------------------------------------
# д���ݵ��ļ�-------------------------------
#--------------------------------------------
# # ��JSON����ת��Ϊ�ַ�����ʽ
# json_str = json.dumps(data)
 
# # ָ��Ҫ������ļ�·��������
# filepath = "file.json"
 
# # ���ļ���д��JSON����
# with open(filepath, 'w') as file:
#     file.write(json_str)
    
#---------------------------------------------