import numpy as np
import sklearn as skl
from sklearn import datasets,linear_model
import matplotlib.pyplot as plt
#generate a data set and plot it
#def generate_data():
np.random.seed(0)
X, y = skl.datasets.make_moons(200,noise=.20)
plt.scatter(X[:,0], X[:,1],s =40, c=y, cmap=plt.cm.Spectral)
plt.show()


#def visualize(X, y, model):
    # plt.scatter(X[:, 0], X[:, 1], s=40, c=y, cmap=plt.cm.Spectral)
    # plt.show()
#   plot_decision_boundary(lambda x:predict(model,x), X, y)
#    plt.title("Logistic Regression")
