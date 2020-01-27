$(document).ready(function () {
    var ctx = document.getElementById('myChart');

    if (ctx) {
        ctx.getContext('2d');

        if (ctx.dataset.fuelId) {
            $.get("/Fuels/GetPrices?", { id: ctx.dataset.fuelId }).done(function (response) {
                if (response.success) {
                    var prices = [];
                    var dates = [];

                    response.data.forEach(function (item) {
                        prices.push(item.pricePerLiter);
                        dates.push(item.date);
                    });

                    new Chart(ctx, {
                        type: 'line',
                        data: {
                            labels: dates,
                            datasets: [{
                                data: prices,
                                label: 'Цена',
                                borderColor: "#3e95cd"
                            }]
                        },
                        options: {
                            responsive: false
                        }
                    });
                }
            });
        } else if (ctx.dataset.fuelTankSize && ctx.dataset.fuelTankValue) {
            new Chart(ctx, {
                type: 'doughnut',
                data: {
                    labels: ['Занято', 'Свободно'],
                    datasets: [{
                        data: [ctx.dataset.fuelTankValue, ctx.dataset.fuelTankSize - ctx.dataset.fuelTankValue],
                        label: 'dataset',
                        backgroundColor: ["rgb(255, 99, 132)", "rgb(54, 162, 235)"]
                    }]
                },
                options: {
                    responsive: false
                }
            });
        } else if (ctx.dataset.statusDetailsId) {
            $.get("/Fuels/GetFuelTanksByFuelId?", { id: ctx.dataset.statusDetailsId }).done(function (response) {
                if (response.success) {
                    var fuelTanks = [];
                    var values = [];

                    response.data.forEach(function (item) {
                        fuelTanks.push(item.id);
                        values.push(item.value);
                    });

                    new Chart(ctx, {
                        type: 'bar',
                        data: {
                            labels: fuelTanks,
                            datasets: [{
                                data: values,
                                label: 'Доступный объем',
                                borderColor: "#3e95cd",
                                backgroundColor: "rgb(54, 162, 235)"
                            }]
                        },
                        options: {
                            responsive: false
                        }
                    });
                }
            });
        } else if (ctx.dataset.incomeAndExpenses) {
            $.get("/IncomeAndExpenses/GetByDate?", { startDate: ctx.dataset.startDate, endDate: ctx.dataset.endDate }).done(function (response) {
                if (response.success) {
                    var dates = [];
                    var incomes = [];
                    var expenses = [];

                    response.data.forEach(function (item) {
                        dates.push(item.date);

                        if (item.value >= 0) {
                            incomes.push(item.value);
                            expenses.push(0);
                        }

                        else {
                            expenses.push(Math.abs(item.value));
                            incomes.push(0);
                        }
                            
                    });
                    new Chart(ctx, {
                        type: 'line',
                        data: {
                            labels: dates,
                            datasets: [{
                                data: incomes,
                                label: 'Приход',
                                borderColor: "rgb(54, 162, 235)",
                            }, {
                                data: expenses,
                                label: 'Расход',
                                borderColor: "rgb(255, 99, 132)"
                            }]
                        },
                        options: {
                            responsive: false
                        }
                    });
                }
            });
        }
    }
});