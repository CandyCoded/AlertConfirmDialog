build:
	(cd ./Assets/Plugins/CandyCoded.AlertConfirmDialog/Plugins/Android && build-unity-android-plugin -p com.candycoded.alertconfirmdialog AndroidPlugin.java)

deploy:
	git subtree push --prefix Assets/Plugins/CandyCoded.AlertConfirmDialog origin upm

deploy-force:
	git push origin `git subtree split --prefix Assets/Plugins/CandyCoded.AlertConfirmDialog main`:upm --force

clean:
	git clean -xdf
