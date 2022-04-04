import requests
import codecs
from bs4 import BeautifulSoup

ls = []

for i in range(1,3):
    for j in range(22):
        link = "https://www.israelibaby.co.il/name-"+str(i)+"-"+str(j)
        html = requests.get(link).text
        soup = BeautifulSoup(html,"html.parser")
        res = soup.findAll("div", {"class": "name"})
        for x in res:
            ls.append(str(x).replace('<div class="name">','').replace('</div>',''))

f = codecs.open("names.txt", "w", encoding="iso8859-8")
for n in ls:
    f.write(n + "\n")    
f.close()
