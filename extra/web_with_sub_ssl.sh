#!/bin/bash

#############################################
# Created By CyperPool for CyberCore use... #
#############################################

source /etc/functions.sh
source /etc/web.conf

echo
echo
echo -e "$CYAN=> Generating Certbot Request For ${Domain_Name}...$COL_RESET"
echo
sleep 3

sudo mkdir -p /var/www/${Domain_Name}/html
sudo mkdir -p /var/www/_letsencrypt
sudo chown www-data /var/www/_letsencrypt
sudo mkdir -p /etc/letsencrypt/renewal-hooks/post/

hide_output sudo certbot certonly --webroot -d "${Domain_Name}" --register-unsafely-without-email -w /var/www/_letsencrypt -n --agree-tos --force-renewal

echo '#!/bin/bash\nnginx -t && systemctl reload nginx' | sudo -E tee /etc/letsencrypt/renewal-hooks/post/nginx-reload.sh >/dev/null 2>&1

sudo chmod a+x /etc/letsencrypt/renewal-hooks/post/nginx-reload.sh

sudo rm -rf /etc/nginx/sites-available/${Domain_Name}

echo '#############################################
# Source Generated By nginxconfig.io        #
# Updated By CyperPool for CyberCore use... #
#############################################

# NGINX Simple DDOS Defense
limit_conn_zone $binary_remote_addr zone=conn_limit_per_ip:10m;
limit_conn conn_limit_per_ip 80;
limit_req zone=req_limit_per_ip burst=80 nodelay;
limit_req_zone $binary_remote_addr zone=req_limit_per_ip:40m rate=5r/s;

server {
	listen 443 ssl http2;
	listen [::]:443 ssl http2;

	root "/var/www/'"${Domain_Name}"'/html";

	index index.html index.htm index.php;

	server_name '"${Domain_Name}"';

	ssl_certificate /etc/letsencrypt/live/'"${Domain_Name}"'/fullchain.pem;
	ssl_certificate_key /etc/letsencrypt/live/'"${Domain_Name}"'/privkey.pem;
	ssl_trusted_certificate /etc/letsencrypt/live/'"${Domain_Name}"'/chain.pem;

	location / {
		try_files $uri $uri/ =404;
	}
}

server {
	listen 80;
	listen [::]:80;

	server_name '"${Domain_Name}"';

	location ^~ /.well-known/acme-challenge/ {
		root /var/www/_letsencrypt;
	}

	location / {
		return 301 https://'"${Domain_Name}"'$request_uri;
	}
}
' | sudo -E tee /etc/nginx/sites-available/${Domain_Name} >/dev/null 2>&1

sudo ln -s /etc/nginx/sites-available/${Domain_Name} /etc/nginx/sites-enabled/${Domain_Name}

sudo systemctl restart nginx
cd ~