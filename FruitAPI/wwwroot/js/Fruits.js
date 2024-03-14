const uri = 'api/Fruits/GetFruits';
let fruits = [];

function getFruits() {
    fetch(uri)
        .then(response => response.json())
        .then(data => DisplayFruits(data,''))
        .catch(error => console.error('Unable to get items.', error));
 }

function DisplayFruits(data, pickedDate) {
    const tBody = document.getElementById('fruits');
    tBody.innerHTML = '';

    data.forEach(item => {

        let usDate = new Date(Date.parse(item.datePicked));
        if (pickedDate != '') {
            let compareDate = new Date(Date.parse(pickedDate));
            if (usDate <= compareDate) {
                return;
            }
        }
        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let nameNode = document.createTextNode(item.fruitName);
        td1.appendChild(nameNode);

        let td2 = tr.insertCell(1);
        let weightNode = document.createTextNode(item.weight.toFixed(2));
        td2.style.textAlign = "right";
        td2.appendChild(weightNode);

        let td3 = tr.insertCell(2);
        let priceNode = document.createTextNode(Intl.NumberFormat('en-US', { style: 'currency', currency: 'USD' }).format(item.price));
        td3.style.textAlign = "right";
        td3.appendChild(priceNode);

        let td4 = tr.insertCell(3);
        let colorNode = document.createTextNode(item.color);
        td4.appendChild(colorNode);

        let td5 = tr.insertCell(4);
        let pickedNode = document.createTextNode(usDate.toLocaleDateString('en-US'));
        td5.style.textAlign = "right";
        td5.appendChild(pickedNode);

        let td6 = tr.insertCell(5);
        let seedNode = document.createTextNode(item.hasSeeds);
        //td6.appendChild(seedNode);
        let chkHasSeeds = document.createElement('input');
        chkHasSeeds.setAttribute('type', 'checkbox');
        if (item.hasSeeds == true) {
            chkHasSeeds.setAttribute('checked', true);
        }
        td6.appendChild(chkHasSeeds);

    });
    fruits = data;
}

$("#pickedAfter")
    .datepicker({
        showOn: "button",
        buttonImage: "images/calendar.gif",
        buttonImageOnly: true,
        buttonText: "Select date",
        onSelect: function (dateText) {
            DisplayFruits(fruits ,this.value);
        }
    }).val('');

