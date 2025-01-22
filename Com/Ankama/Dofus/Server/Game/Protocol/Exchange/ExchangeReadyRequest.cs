using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006F0 RID: 1776
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeReadyRequest : IMessage<ExchangeReadyRequest>, IMessage, IEquatable<ExchangeReadyRequest>, IDeepCloneable<ExchangeReadyRequest>, IBufferMessage
	{
		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060056E4 RID: 22244 RVA: 0x002144DC File Offset: 0x002126DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x002144EC File Offset: 0x002126EC
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x002144FC File Offset: 0x002126FC
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

		// Token: 0x060056E7 RID: 22247 RVA: 0x0021450C File Offset: 0x0021270C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyRequest()
		{
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0021451C File Offset: 0x0021271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyRequest(ExchangeReadyRequest other)
		{
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x0021452C File Offset: 0x0021272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060056EA RID: 22250 RVA: 0x0021453C File Offset: 0x0021273C
		// (set) Token: 0x060056EB RID: 22251 RVA: 0x0021454C File Offset: 0x0021274C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Ready
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x0021455C File Offset: 0x0021275C
		// (set) Token: 0x060056ED RID: 22253 RVA: 0x0021456C File Offset: 0x0021276C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Step
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

		// Token: 0x060056EE RID: 22254 RVA: 0x0021457C File Offset: 0x0021277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x0021458C File Offset: 0x0021278C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeReadyRequest other)
		{
			return true;
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0021459C File Offset: 0x0021279C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x002145AC File Offset: 0x002127AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x002145BC File Offset: 0x002127BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x002145CC File Offset: 0x002127CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x002145DC File Offset: 0x002127DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x002145EC File Offset: 0x002127EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeReadyRequest other)
		{
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x002145FC File Offset: 0x002127FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x0021460C File Offset: 0x0021280C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x0021461C File Offset: 0x0021281C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeReadyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeReadyRequest._parser = new MessageParser<ExchangeReadyRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x00214700 File Offset: 0x00212900
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Bal8yYOMY0HOEREBAmi7()
		{
			return true;
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x00214708 File Offset: 0x00212908
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeReadyRequest cLRgCKOMbDbblmZWuKfd()
		{
			return null;
		}

		// Token: 0x04001E6D RID: 7789
		private static readonly MessageParser<ExchangeReadyRequest> _parser;

		// Token: 0x04001E6E RID: 7790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E6F RID: 7791
		public const int ReadyFieldNumber = 1;

		// Token: 0x04001E70 RID: 7792
		private bool ready_;

		// Token: 0x04001E71 RID: 7793
		public const int StepFieldNumber = 2;

		// Token: 0x04001E72 RID: 7794
		private int step_;

		// Token: 0x04001E73 RID: 7795
		private static ExchangeReadyRequest WrwaqVOMHjIJXKkEEgYl;
	}
}
