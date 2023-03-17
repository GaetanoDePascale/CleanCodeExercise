// Better Code
function isItalianFiscalCodeValid(code) {
    const VALID_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    const VALID_ODD_CHAR_SET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const VALID_EVEN_CHAR_SET = "ABCDEFGHIJABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const CONTROL_CHAR_SET = "BAKPLCQDREVOSFTGUHMINJWZYX";

    if (!code || code.length !== 16) {
        return false;
    }

    code = code.toUpperCase();

    for (let i = 0; i < 16; i++) {
        if (VALID_CHARS.indexOf(code.charAt(i)) === -1) {
            return false;
        }
    }

    let oddSum = 0;
    let evenSum = 0;

    for (let i = 1; i <= 13; i += 2) {
        const oddCharIndex = VALID_ODD_CHAR_SET.indexOf(code.charAt(i));
        const evenCharIndex = VALID_EVEN_CHAR_SET.indexOf(code.charAt(i - 1));

        oddSum += CONTROL_CHAR_SET.charAt(oddCharIndex).charCodeAt(0) - 'A'.charCodeAt(0);
        evenSum += CONTROL_CHAR_SET.charAt(evenCharIndex).charCodeAt(0) - 'A'.charCodeAt(0);
    }

    const controlChar = (oddSum + evenSum) % 26;

    return controlChar === code.charCodeAt(15) - 'A'.charCodeAt(0);
}