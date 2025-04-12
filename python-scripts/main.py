fileName = "D:\\25\\Яриго\\Задание СУБД Атосервис\\Ресурсы 1\\service_a_import.csv"

with open(fileName) as file:
    lines = file.readlines()

for i in range(len(lines)):
    lines[i] = lines[i].replace(",", ";").replace(".", "").replace("?", "").replace("%", "")

for i in range(len(lines)):
    parts = lines[i].split(";")
    time = parts[1].strip().split(" ")
    price = parts[2].strip().split(" ")
    discount = parts[3].strip().split(" ")
    if "мин" in time:
        minutes = int(time[0])
        secs = int(minutes * 60)
        parts[1] = str(secs)
    if "час" in time:
        hours = int(time[0])
        secs = int(hours * 60 * 60)
        parts[1] = str(secs)
    if "сек" in time:
        secs = int(time[0])
        parts[1] = str(secs)
    if "руб" in price:
        true_price = int(price[0])
        parts[2] = str(true_price)
    if "рублей" in price:
        true_price = int(price[0])
        parts[2] = str(true_price)
    if "нет" in discount:
        discount[0] = str(0)
    if "Действующая" not in discount:
        discount = float(discount[0]) / 100
        parts[3] = (str(discount)).strip().replace(".", ",") + '\n'
    lines[i] = ";".join(parts)
print("".join(lines))
f = "".join(lines).replace("," ".")
with open(fileName, 'w') as file:
    file.write(f)