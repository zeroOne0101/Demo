
import json
import urllib.request

#--------------------------------------------
# 获取json数据-------------------------------
#--------------------------------------------
#方式一：从api获取JSON
# bdUrl="https://finance.pae.baidu.com/selfselect/getstockquotation?code=000300&all=1&ktype=2&isIndex=true&isBk=false&isBlock=false&stockType=ab&market_type=ab&group=quotation_index_kline&finClientType=pc" 

# with urllib.request.urlopen(bdUrl) as url:

#     data = json.loads(url.read().decode())


#方式二：从json文件读取json数据
with open('file.json') as f:

    data = json.load(f)

# print(data)
print(data['Result'][-1]['ma20']['avgPrice']) 
# print(data['QueryID']) 

 

#--------------------------------------------
# 写数据到文件-------------------------------
#--------------------------------------------
# # 将JSON数据转换为字符串格式
# json_str = json.dumps(data)
 
# # 指定要保存的文件路径及名称
# filepath = "file.json"
 
# # 打开文件并写入JSON数据
# with open(filepath, 'w') as file:
#     file.write(json_str)
    
#---------------------------------------------