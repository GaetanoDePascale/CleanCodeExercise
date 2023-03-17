// Bad Code
const images = {
    disabled: 'disabledImageUrl',
    notAvailable: 'notAvailableUrl'
}

function getUserImage(user, isImageEnabled) {
    return isImageEnabled ? user.profileImage !== undefiend ? user.profileImage : images.notAvailable : images.disabled;
}
