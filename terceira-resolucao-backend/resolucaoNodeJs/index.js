const faturamento = [1000, 1500, 0, 2000, 1200, 0, 1800];

function analisarFaturamento(faturamento) {
    let menorValor = Number.MAX_VALUE;
    let maiorValor = Number.MIN_VALUE;
    let somaTotal = 0;
    let diasComFaturamento = 0;
    let diasAcimaMedia = 0;

    faturamento.forEach(valor => {
        if (valor > 0) {
            somaTotal += valor;
            diasComFaturamento++;
            menorValor = Math.min(menorValor, valor);
            maiorValor = Math.max(maiorValor, valor);
        }
    });

    const mediaAnual = somaTotal / diasComFaturamento;

    faturamento.forEach(valor => {
        if (valor > mediaAnual) {
            diasAcimaMedia++;
        }
    });

    return {
        menorValor,
        maiorValor,
        mediaAnual,
        diasAcimaMedia
    };
}

const resultado = analisarFaturamento(faturamento);

console.log(`Menor valor: ${resultado.menorValor}`);
console.log(`Maior valor: ${resultado.maiorValor}`);
console.log(`Média anual: ${resultado.mediaAnual}`);
console.log(`Dias acima da média: ${resultado.diasAcimaMedia}`);