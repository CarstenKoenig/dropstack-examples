FROM haskell:8.0
EXPOSE 80
RUN stack setup
ADD . /app
WORKDIR /app
RUN stack install
ENTRYPOINT ~/.local/bin/$(find . -name *.cabal -print | head -n 5 | grep -o '[^/]*$' | cut -d'.' -f1)
