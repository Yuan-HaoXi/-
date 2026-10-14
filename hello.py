"""一个简单的 Python 问候程序。"""

import argparse


def main():
    parser = argparse.ArgumentParser(description="向你打招呼")
    parser.add_argument("name", nargs="?", default="世界", help="你的名字")
    args = parser.parse_args()
    print(f"你好，{args.name}！")


if __name__ == "__main__":
    main()
