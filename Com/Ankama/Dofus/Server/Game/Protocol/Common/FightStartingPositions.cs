using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000ABA RID: 2746
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightStartingPositions : IMessage<FightStartingPositions>, IMessage, IEquatable<FightStartingPositions>, IDeepCloneable<FightStartingPositions>, IBufferMessage
	{
		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x0026339C File Offset: 0x0026159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightStartingPositions> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x002633AC File Offset: 0x002615AC
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

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x002633BC File Offset: 0x002615BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x002633CC File Offset: 0x002615CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingPositions()
		{
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x002633DC File Offset: 0x002615DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingPositions(FightStartingPositions other)
		{
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x002633EC File Offset: 0x002615EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingPositions Clone()
		{
			return null;
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06008356 RID: 33622 RVA: 0x002633FC File Offset: 0x002615FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ChallengersPositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06008357 RID: 33623 RVA: 0x0026340C File Offset: 0x0026160C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DefendersPositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0026341C File Offset: 0x0026161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0026342C File Offset: 0x0026162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightStartingPositions other)
		{
			return true;
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x0026343C File Offset: 0x0026163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x0026344C File Offset: 0x0026164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0026345C File Offset: 0x0026165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0026346C File Offset: 0x0026166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0026347C File Offset: 0x0026167C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0026348C File Offset: 0x0026168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightStartingPositions other)
		{
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0026349C File Offset: 0x0026169C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x002634AC File Offset: 0x002616AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x002634BC File Offset: 0x002616BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightStartingPositions()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightStartingPositions._parser = new MessageParser<FightStartingPositions>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					return;
				case 6:
					FightStartingPositions._repeated_defendersPositions_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					continue;
				}
				FightStartingPositions._repeated_challengersPositions_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 6;
			}
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x002635F0 File Offset: 0x002617F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GiGHTmJsN6o757dc8owD()
		{
			return true;
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x002635F8 File Offset: 0x002617F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightStartingPositions GY9PYFJsxCFBAejG9uV2()
		{
			return null;
		}

		// Token: 0x04002FDF RID: 12255
		private static readonly MessageParser<FightStartingPositions> _parser;

		// Token: 0x04002FE0 RID: 12256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE1 RID: 12257
		public const int ChallengersPositionsFieldNumber = 1;

		// Token: 0x04002FE2 RID: 12258
		private static readonly FieldCodec<int> _repeated_challengersPositions_codec;

		// Token: 0x04002FE3 RID: 12259
		private readonly RepeatedField<int> challengersPositions_;

		// Token: 0x04002FE4 RID: 12260
		public const int DefendersPositionsFieldNumber = 2;

		// Token: 0x04002FE5 RID: 12261
		private static readonly FieldCodec<int> _repeated_defendersPositions_codec;

		// Token: 0x04002FE6 RID: 12262
		private readonly RepeatedField<int> defendersPositions_;

		// Token: 0x04002FE7 RID: 12263
		internal static FightStartingPositions mku1QIJsXXby8l6jBVd0;
	}
}
