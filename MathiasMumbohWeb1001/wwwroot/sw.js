//var CACHE_NAME = 'my-site-cache-V1';
//var urlsToCache = [
//    '/ '
//];

//self.addEventListener('install', function (event) {
//    // Perform install steps
//    console.info('Service Worker is Available in this site....');

//    event.waitUntil(
//        caches.open(CACHE_NAME)
//            .then(function (cache) {
//                console.log('Opened cache');
//                return cache.addAll(urlsToCache);
//            })
//    );
//    console.info('caching started');
//});

//self.addEventListener('fetch', function (event) {
//    event.respondWith(
//        caches.match(event.request)
//            .then(function (response) {
//                // Cache hit - return response
//                if (response) {
//                    return response;
//                }
//                return fetch(event.request);
//            }
//            )
//    );
//});

const cacheName = 'cache-V1';
let urlsToCache = [
    '/ ',
    '/css/site.cs',
    '/js/site.js'
];

self.addEventListener('install', (event) => {
    console.info('service worker installing...');

    event.waitUntil(
        caches.open(cacheName)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );
    console.info('caching started...');

});

self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                // Cache hit - return response
                if (response) {
                    return response;
                }
                return fetch(event.request);
            }
            )
    );
});