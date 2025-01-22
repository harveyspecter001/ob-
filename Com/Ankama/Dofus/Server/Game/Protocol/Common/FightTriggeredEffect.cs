using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000ACB RID: 2763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTriggeredEffect : IMessage<FightTriggeredEffect>, IMessage, IEquatable<FightTriggeredEffect>, IDeepCloneable<FightTriggeredEffect>, IBufferMessage
	{
		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600841A RID: 33818 RVA: 0x002640AC File Offset: 0x002622AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTriggeredEffect> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600841B RID: 33819 RVA: 0x002640BC File Offset: 0x002622BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600841C RID: 33820 RVA: 0x002640CC File Offset: 0x002622CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x002640DC File Offset: 0x002622DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTriggeredEffect()
		{
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x002640EC File Offset: 0x002622EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTriggeredEffect(FightTriggeredEffect other)
		{
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x002640FC File Offset: 0x002622FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTriggeredEffect Clone()
		{
			return null;
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06008420 RID: 33824 RVA: 0x0026410C File Offset: 0x0026230C
		// (set) Token: 0x06008421 RID: 33825 RVA: 0x0026411C File Offset: 0x0026231C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06008422 RID: 33826 RVA: 0x0026412C File Offset: 0x0026232C
		// (set) Token: 0x06008423 RID: 33827 RVA: 0x0026413C File Offset: 0x0026233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06008424 RID: 33828 RVA: 0x0026414C File Offset: 0x0026234C
		// (set) Token: 0x06008425 RID: 33829 RVA: 0x0026415C File Offset: 0x0026235C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ThirdParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x0026416C File Offset: 0x0026236C
		// (set) Token: 0x06008427 RID: 33831 RVA: 0x0026417C File Offset: 0x0026237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0026418C File Offset: 0x0026238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x0026419C File Offset: 0x0026239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTriggeredEffect other)
		{
			return true;
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x002641AC File Offset: 0x002623AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x002641BC File Offset: 0x002623BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x002641CC File Offset: 0x002623CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x002641DC File Offset: 0x002623DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x002641EC File Offset: 0x002623EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x002641FC File Offset: 0x002623FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTriggeredEffect other)
		{
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0026420C File Offset: 0x0026240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x0026421C File Offset: 0x0026241C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x0026422C File Offset: 0x0026242C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTriggeredEffect()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				FightTriggeredEffect._parser = new MessageParser<FightTriggeredEffect>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x002642F8 File Offset: 0x002624F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yIk47TJsyCu03YgkcxPM()
		{
			return true;
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x00264300 File Offset: 0x00262500
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTriggeredEffect vCiNoeJs6uH1fQOSpEF5()
		{
			return null;
		}

		// Token: 0x0400303C RID: 12348
		private static readonly MessageParser<FightTriggeredEffect> _parser;

		// Token: 0x0400303D RID: 12349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400303E RID: 12350
		public const int FirstParamFieldNumber = 1;

		// Token: 0x0400303F RID: 12351
		private int firstParam_;

		// Token: 0x04003040 RID: 12352
		public const int SecondParamFieldNumber = 2;

		// Token: 0x04003041 RID: 12353
		private int secondParam_;

		// Token: 0x04003042 RID: 12354
		public const int ThirdParamFieldNumber = 3;

		// Token: 0x04003043 RID: 12355
		private int thirdParam_;

		// Token: 0x04003044 RID: 12356
		public const int DelayFieldNumber = 4;

		// Token: 0x04003045 RID: 12357
		private int delay_;

		// Token: 0x04003046 RID: 12358
		private static FightTriggeredEffect Hy1sX5Js5lrGUh7gmvHm;
	}
}
