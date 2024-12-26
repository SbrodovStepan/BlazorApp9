let map;

function initializeMap() {
    map = L.map('map').setView([57.1522, 65.5272], 13);
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '© OpenStreetMap contributors'
    }).addTo(map);
}

function addRouteToMap(startLat, startLon, endLat, endLon) {
    const route = L.polyline(
        [
            [startLat, startLon],
            [endLat, endLon]
        ],
        { color: 'blue' }
    ).addTo(map);
    map.fitBounds(route.getBounds());
}
