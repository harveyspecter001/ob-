using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000969 RID: 2409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachTeleportRequest : IMessage<BreachTeleportRequest>, IMessage, IEquatable<BreachTeleportRequest>, IDeepCloneable<BreachTeleportRequest>, IBufferMessage
	{
		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x00241DF0 File Offset: 0x0023FFF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachTeleportRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x00241E00 File Offset: 0x00240000
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

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x00241E10 File Offset: 0x00240010
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

		// Token: 0x060074A2 RID: 29858 RVA: 0x00241E20 File Offset: 0x00240020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportRequest()
		{
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x00241E30 File Offset: 0x00240030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportRequest(BreachTeleportRequest other)
		{
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00241E40 File Offset: 0x00240040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportRequest Clone()
		{
			return null;
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00241E50 File Offset: 0x00240050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x00241E60 File Offset: 0x00240060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachTeleportRequest other)
		{
			return true;
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x00241E70 File Offset: 0x00240070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x00241E80 File Offset: 0x00240080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x00241E90 File Offset: 0x00240090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00241EA0 File Offset: 0x002400A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00241EB0 File Offset: 0x002400B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00241EC0 File Offset: 0x002400C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachTeleportRequest other)
		{
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00241ED0 File Offset: 0x002400D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x00241EE0 File Offset: 0x002400E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x00241EF0 File Offset: 0x002400F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachTeleportRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				BreachTeleportRequest._parser = new MessageParser<BreachTeleportRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x00241FBC File Offset: 0x002401BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cvnKD5JRnoGAeLlA1yKV()
		{
			return true;
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00241FC4 File Offset: 0x002401C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachTeleportRequest bu9qIjJRmjk15YMRMssT()
		{
			return null;
		}

		// Token: 0x040028AF RID: 10415
		private static readonly MessageParser<BreachTeleportRequest> _parser;

		// Token: 0x040028B0 RID: 10416
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B1 RID: 10417
		internal static BreachTeleportRequest XWV2feJRfCTcEDsXqKGy;
	}
}
