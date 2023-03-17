// Better Code
const MINIMUM_AGE_TO_BET = 18;
const MINIMUM_BET_COST = 2.00;

function canBet(age, money) {
    return (age >= MINIMUM_AGE_TO_MAKE_A_BET && money >= MINIMUM_BET_COST);
}
