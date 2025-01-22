using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007CA RID: 1994
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockableChangeCodeRequest : IMessage<LockableChangeCodeRequest>, IMessage, IEquatable<LockableChangeCodeRequest>, IDeepCloneable<LockableChangeCodeRequest>, IBufferMessage
	{
		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x00221C8C File Offset: 0x0021FE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockableChangeCodeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060061BA RID: 25018 RVA: 0x00221C9C File Offset: 0x0021FE9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x00221CAC File Offset: 0x0021FEAC
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

		// Token: 0x060061BC RID: 25020 RVA: 0x00221CBC File Offset: 0x0021FEBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableChangeCodeRequest()
		{
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00221CCC File Offset: 0x0021FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableChangeCodeRequest(LockableChangeCodeRequest other)
		{
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00221CDC File Offset: 0x0021FEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableChangeCodeRequest Clone()
		{
			return null;
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x00221CEC File Offset: 0x0021FEEC
		// (set) Token: 0x060061C0 RID: 25024 RVA: 0x00221CFC File Offset: 0x0021FEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Code
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x00221D0C File Offset: 0x0021FF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00221D1C File Offset: 0x0021FF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LockableChangeCodeRequest other)
		{
			return true;
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00221D2C File Offset: 0x0021FF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x00221D3C File Offset: 0x0021FF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00221D4C File Offset: 0x0021FF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x00221D5C File Offset: 0x0021FF5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x00221D6C File Offset: 0x0021FF6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x00221D7C File Offset: 0x0021FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LockableChangeCodeRequest other)
		{
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x00221D8C File Offset: 0x0021FF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x00221D9C File Offset: 0x0021FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x00221DAC File Offset: 0x0021FFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LockableChangeCodeRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					LockableChangeCodeRequest._parser = new MessageParser<LockableChangeCodeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x00221E90 File Offset: 0x00220090
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool acUNR5OFxOdQgiRqFrZI()
		{
			return true;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00221E98 File Offset: 0x00220098
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LockableChangeCodeRequest mYp382OF4IXwMLiU2Tp1()
		{
			return null;
		}

		// Token: 0x04002256 RID: 8790
		private static readonly MessageParser<LockableChangeCodeRequest> _parser;

		// Token: 0x04002257 RID: 8791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002258 RID: 8792
		public const int CodeFieldNumber = 1;

		// Token: 0x04002259 RID: 8793
		private string code_;

		// Token: 0x0400225A RID: 8794
		internal static LockableChangeCodeRequest g4Ud8pOFNfSx9kcfcaoW;
	}
}
