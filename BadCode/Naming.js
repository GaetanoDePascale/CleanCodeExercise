// Bad Code
function check(value) {
    let validi, i, s, set1, set2, setp, setd;

    if (value === '') return false;
    if (value.length !== 16) return false;

    validi = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    value = value.toUpperCase();

    for (i = 0; i < 16; i++) {
        if (validi.indexOf(value.charAt(i)) == -1) return false;
    }
    set1 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    set2 = "ABCDEFGHIJABCDEFGHIJKLMNOPQRSTUVWXYZ";
    setp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    setd = "BAKPLCQDREVOSFTGUHMINJWZYX";

    s = 0;

    for (i = 1; i <= 13; i += 2) s += setp.indexOf(set2.charAt(set1.indexOf(value.charAt(i))));
    for (i = 0; i <= 14; i += 2)  s += setd.indexOf(set2.charAt(set1.indexOf(value.charAt(i))));

    if (s % 26 !== value.charCodeAt(15) - 'A'.charCodeAt(0)) return false;

    return true;
}
