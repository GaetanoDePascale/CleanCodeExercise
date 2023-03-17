// Better Code
const images = {
    disabled: 'disabledImageUrl',
    notAvailable: 'notAvailableUrl'
}

function getUserImage(user, isImageEnabled) {
    if (!isImageEnabled) {
        return images.disabled;
    }

    if (user.profileImage === undefiend) {
        return images.notAvailable;
    }

    return user.profileImage;
}
