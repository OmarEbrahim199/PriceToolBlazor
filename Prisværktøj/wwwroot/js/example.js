

function toggleIcons() {
  
    var toggleButton = document.getElementById('iconToggleButton');
    if (toggleButton) {
      
        var downIcon = document.getElementById('downIcon');
        var upIcon = document.getElementById('upIcon');

        if (downIcon.classList.contains('d-none')) {
           
            downIcon.classList.remove('d-none');
            upIcon.classList.add('d-none');
        } else {
           
            downIcon.classList.add('d-none');
            upIcon.classList.remove('d-none');
        }
    } else {
       
    }
}
