const descobrirProximoElemento = (sequencia, nome) => {
    let proximo;

    switch (nome) {
        case 'a':
            if (sequencia.every((num, index) => index === 0 || num === sequencia[index - 1] + 2))
                proximo = sequencia[sequencia.length - 1] + 2;
            break;
        case 'b':
            proximo = sequencia[sequencia.length - 1] * 2;
            break;
        case 'c':
            proximo = (sequencia.length) ** 2;
            break;
        case 'd':
            proximo = ((sequencia.length + 1) * 2) ** 2;
            break;
        case 'e':
            proximo = sequencia[sequencia.length - 1] + sequencia[sequencia.length - 2];
            break;
        case 'f':
            proximo = sequencia[sequencia.length - 1] + 1;
            break;
        default:
            return "Sequência não reconhecida";
    }

    return proximo;
};

const sequencias = {
    a: [1, 3, 5, 7],
    b: [2, 4, 8, 16, 32, 64],
    c: [0, 1, 4, 9, 16, 25, 36],
    d: [4, 16, 36, 64],
    e: [1, 1, 2, 3, 5, 8],
    f: [2, 10, 12, 16, 17, 18, 19]
};

Object.entries(sequencias).forEach(([nome, sequencia]) => {
    const proximo = descobrirProximoElemento(sequencia, nome);
    console.log(`${nome}) ${sequencia.join(', ')}, próximo: ${proximo}`);
});