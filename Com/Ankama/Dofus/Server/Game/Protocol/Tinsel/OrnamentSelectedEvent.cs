using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000079 RID: 121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OrnamentSelectedEvent : IMessage<OrnamentSelectedEvent>, IMessage, IEquatable<OrnamentSelectedEvent>, IDeepCloneable<OrnamentSelectedEvent>, IBufferMessage
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00189BC8 File Offset: 0x00187DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OrnamentSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00189BD8 File Offset: 0x00187DD8
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00189BE8 File Offset: 0x00187DE8
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

		// Token: 0x060004D6 RID: 1238 RVA: 0x00189BF8 File Offset: 0x00187DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectedEvent()
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00189C08 File Offset: 0x00187E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectedEvent(OrnamentSelectedEvent other)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00189C18 File Offset: 0x00187E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00189C28 File Offset: 0x00187E28
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00189C38 File Offset: 0x00187E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
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

		// Token: 0x060004DB RID: 1243 RVA: 0x00189C48 File Offset: 0x00187E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00189C58 File Offset: 0x00187E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OrnamentSelectedEvent other)
		{
			return true;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00189C68 File Offset: 0x00187E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00189C78 File Offset: 0x00187E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00189C88 File Offset: 0x00187E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00189C98 File Offset: 0x00187E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00189CA8 File Offset: 0x00187EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00189CB8 File Offset: 0x00187EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OrnamentSelectedEvent other)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00189CC8 File Offset: 0x00187EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00189CD8 File Offset: 0x00187ED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00189CE8 File Offset: 0x00187EE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OrnamentSelectedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OrnamentSelectedEvent._parser = new MessageParser<OrnamentSelectedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00189DCC File Offset: 0x00187FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ynVG1dOKonZIKcx63aLi()
		{
			return true;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00189DD4 File Offset: 0x00187FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OrnamentSelectedEvent QXTx3aOK18S1botMaWWb()
		{
			return null;
		}

		// Token: 0x040001E1 RID: 481
		private static readonly MessageParser<OrnamentSelectedEvent> _parser;

		// Token: 0x040001E2 RID: 482
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001E3 RID: 483
		public const int OrnamentIdFieldNumber = 1;

		// Token: 0x040001E4 RID: 484
		private int ornamentId_;

		// Token: 0x040001E5 RID: 485
		private static OrnamentSelectedEvent VDy6uPOKv1vOq4ikGlJq;
	}
}
