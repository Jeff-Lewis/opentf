#!/bin/sh
SERVER=$1
LOGIN=$2
WORKSPACE=$3
SERVER_PATH=$4
echo tf /server:$SERVER /login:$LOGIN workfold $SERVER_PATH /tmp/tf4mono
tf /server:$SERVER /login:$LOGIN workfold $SERVER_PATH /tmp/tf4mono
